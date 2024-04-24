using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using TMPro;
using System.Linq;

public class Submit_System : MonoBehaviour, IDropHandler
{
    public UI_Manager ui_script;  //manager script
    public GameObject end_panel;  //prefab of end game panel
    public GameObject item_sample;  //prefab of item in show panel

    public GameObject current_object;  //current character name display
    public GameObject show_panel;  //show panel content

    public List<Sprite> object_sprite_list;  //character sprite list
    public List<List<(int, string)>> object_name_list;  //character sprite number and name list
    public Sprite concept_block_sprite;
    public int current_object_num;  //current character number
    public int current_sub_task_num;  //current subtask number

    public List<List<Concept_Info>> submitted_concept_info;  //submitted concept list
    private List<List<List<Concept_Info>>> answer;  //answer list
    private List<int> correct_concept_num;  //correct answer list
    private bool checked_flag;  //whether concept is checked

    //Initialize the setting
    void Start()
    {
        show_panel = transform.Find("Concept_Panel").Find("Scroll View").Find("Viewport").Find("Content").gameObject;
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();

        current_object = gameObject.transform.Find("Object_Shown").gameObject;
        current_object.transform.GetComponent<Image>().color = new Color(255,255,225,255);
        current_object_num = 0;
        current_sub_task_num = ui_script.GetSubTaskNum();

        object_sprite_list = ui_script.GetObjectSprites();
        object_name_list = ui_script.GetObjectNames();
        answer = ui_script.GetAnswer();
        submitted_concept_info = ui_script.GetCurrentAnswer();

        current_object.GetComponent<Image>().sprite = object_sprite_list[object_name_list[current_sub_task_num][current_object_num].Item1];
        transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().SetText(object_name_list[current_sub_task_num][current_object_num].Item2);
        UpdateConceptPanel();
    }

    //Control to the previous character
    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_object_num > 0) {
            current_object_num -= 1;
            current_object.GetComponent<Image>().sprite = object_sprite_list[object_name_list[current_sub_task_num][current_object_num].Item1];
            transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
            UpdateConceptPanel();
        }
    }

    //Control to the next character
    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_object_num < object_name_list[current_sub_task_num].Count - 1) {
            current_object_num += 1;
            current_object.GetComponent<Image>().sprite = object_sprite_list[object_name_list[current_sub_task_num][current_object_num].Item1];
            transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
            UpdateConceptPanel();
        }
    }

    //Clear current character submitted concept
    public void ClearButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
        submitted_concept_info[current_object_num].Clear();
        ui_script.AddCurrentAnswer(submitted_concept_info);
        UpdateConceptPanel();
    }

    //Submit and check process
    public void SubmitButtonEvent() {
        bool submit_state = Check();

        if (submit_state) {
            //task completed
            if (ui_script.GetSubTaskTotal() - 1 == ui_script.GetSubTaskNum()) {
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(1);
                ui_script.SetPlayerStatus();
                ui_script.Blur_Screen();
                //call end panel and edit message
                GameObject panel = Instantiate(end_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
                Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                panel.transform.position = new Vector3(center.x,center.y,0);
                string message = "Task " + ui_script.GetTask().ToString() + " Completed!";
                panel.transform.Find("Text").GetComponent<TMP_Text>().SetText(message);
            }
            else {
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(1);
                //update current subtask
                ui_script.SetSubTaskNum();
                current_sub_task_num = ui_script.GetSubTaskNum();
                current_object_num = 0;
                //clear submitted concept
                for (int i = 0; i < submitted_concept_info.Count; i++) {
                    submitted_concept_info[i].Clear();
                }
                //update submitted concept to manager
                ui_script.AddCurrentAnswer(submitted_concept_info);
                //update show panel
                UpdateConceptPanel();
                transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
            }
        }
        else {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(2);
            UpdateConceptPanel();
            //if answer is not correct, perform notification on the show panel
            transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.red;
            if (checked_flag) {
                foreach (Transform item in show_panel.transform) {
                    if (correct_concept_num.Contains(item.GetSiblingIndex())) {
                        item.GetComponent<Image>().color = Color.green;
                    }
                    else {
                        item.GetComponent<Image>().color = Color.red;
                    }
                }
            }
        }
    }

    //Checking process
    private bool Check() {
        int subtask = ui_script.GetSubTaskNum();
        correct_concept_num = new List<int>();
        for (int i = 0; i < object_name_list[current_sub_task_num].Count; i++) {
            //empty check case
            if (answer[subtask][i] == null) {
                if (submitted_concept_info[i].Count != 0) {
                    current_object_num = i;
                    checked_flag = false;
                    return false;
                }
            }
            else{
                //expected answer check case
                if (submitted_concept_info[i].Count != answer[subtask][i].Count){
                    current_object_num = i;
                    checked_flag = false;
                    return false;
                }
                else {
                    checked_flag = true;
                    foreach (Concept_Info concept_info in answer[subtask][i]) {
                        //perform concept matching
                        if (submitted_concept_info[i].Any(x => concept_info.Equals(x))) {
                            correct_concept_num.Add(submitted_concept_info[i].IndexOf(concept_info));
                        } 
                    }
                    if (correct_concept_num.Count != answer[subtask][i].Count) {
                        return false;
                    }
                    else {
                        correct_concept_num.Clear();
                    }
                }
            } 
        }
        return true;
    }

    //Concept submission process
    public void OnDrop(PointerEventData eventData) {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (eventData.pointerDrag.transform.Find("Icon").GetComponent<Image>().sprite == concept_block_sprite) {
            Draggable_Concept con = eventData.pointerDrag.transform.GetComponent<Draggable_Concept>();
            submitted_concept_info[current_object_num].Add(con.concept_info);
            ui_script.AddCurrentAnswer(submitted_concept_info);
        }
        else {
            Combined_Action_Card con = eventData.pointerDrag.transform.GetComponent<Combined_Action_Card>();
            submitted_concept_info[current_object_num].Add(con.concept_info);
            ui_script.AddCurrentAnswer(submitted_concept_info);
        }
        UpdateConceptPanel();
    }

    //Update show panel display
    public void UpdateConceptPanel() {
        transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().SetText(object_name_list[current_sub_task_num][current_object_num].Item2);
        current_object.GetComponent<Image>().sprite = object_sprite_list[object_name_list[current_sub_task_num][current_object_num].Item1];
        Empty();
        if (submitted_concept_info[current_object_num].Count > 0) {
            foreach(Concept_Info concept in submitted_concept_info[current_object_num]) {
                CreatedItem(concept);
            }
        } 
    }

    //Create show panel item
    public void CreatedItem(Concept_Info concept) {
        GameObject item = Instantiate(item_sample, show_panel.transform);
        item.transform.Find("Text").GetComponent<TMP_Text>().SetText(concept.nickname);
    }

    //Empty show panel
    private void Empty() {
        foreach (Transform obj in show_panel.transform) {
            Destroy(obj.gameObject);
        }
    }
}
