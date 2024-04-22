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
    public UI_Manager ui_script;
    public GameObject end_panel;
    public GameObject item_sample;

    public GameObject left_button;
    public GameObject right_button;
    public GameObject clear_button;
    public GameObject submit_button;
    public GameObject current_object;
    public GameObject show_panel;

    public List<Sprite> object_sprite_list;
    public List<List<(int, string)>> object_name_list;
    public Sprite concept_block_sprite;
    public Sprite action_card_sprite;
    public int current_object_num;
    public int current_sub_task_num;

    public List<List<Concept_Info>> submitted_concept_info;
    private List<List<List<Concept_Info>>> answer;
    private List<int> correct_concept_num;
    private bool checked_flag;

    void Start()
    {
        left_button = gameObject.transform.Find("Left_Button").gameObject;
        right_button = gameObject.transform.Find("Right_Button").gameObject;
        clear_button = gameObject.transform.Find("Clear_Button").gameObject;
        submit_button = gameObject.transform.Find("Submit_Button").gameObject;
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

    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_object_num > 0) {
            current_object_num -= 1;
            current_object.GetComponent<Image>().sprite = object_sprite_list[object_name_list[current_sub_task_num][current_object_num].Item1];
            transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
            UpdateConceptPanel();
        }
    }

    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_object_num < object_name_list[current_sub_task_num].Count - 1) {
            current_object_num += 1;
            current_object.GetComponent<Image>().sprite = object_sprite_list[object_name_list[current_sub_task_num][current_object_num].Item1];
            transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
            UpdateConceptPanel();
        }
    }

    public void ClearButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
        submitted_concept_info[current_object_num].Clear();
        ui_script.AddCurrentAnswer(submitted_concept_info);
        UpdateConceptPanel();
    }

    public void SubmitButtonEvent() {
        Boolean submit_state = Check();
        if (submit_state) {
            if (ui_script.GetSubTaskTotal() - 1 == ui_script.GetSubTaskNum()) {
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(1);
                ui_script.SetPlayerStatus();
                ui_script.Blur_Screen();
                GameObject panel = Instantiate(end_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
                Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                panel.transform.position = new Vector3(center.x,center.y,0);
                String message = "Task " + ui_script.GetTask().ToString() + " Completed!";
                panel.transform.Find("Text").GetComponent<TMP_Text>().SetText(message);
            }
            else {
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
                GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(1);
                ui_script.SetSubTaskNum();
                current_sub_task_num = ui_script.GetSubTaskNum();
                current_object_num = 0;
                for (int i = 0; i < submitted_concept_info.Count; i++) {
                    submitted_concept_info[i].Clear();
                }
                ui_script.AddCurrentAnswer(submitted_concept_info);
                UpdateConceptPanel();
                transform.Find("Concept_Panel").Find("Text").GetComponent<TMP_Text>().color = Color.white;
            }
        }
        else {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(2);
            UpdateConceptPanel();
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

    private Boolean Check() {
        int subtask = ui_script.GetSubTaskNum();
        correct_concept_num = new List<int>();
        for (int i = 0; i < object_name_list[current_sub_task_num].Count; i++) {
            if (answer[subtask][i] == null) {
                if (submitted_concept_info[i].Count != 0) {
                    current_object_num = i;
                    checked_flag = false;
                    return false;
                }
            }
            else{
                if (submitted_concept_info[i].Count != answer[subtask][i].Count){
                    current_object_num = i;
                    checked_flag = false;
                    return false;
                }
                else {
                    checked_flag = true;
                    foreach (Concept_Info concept_info in answer[subtask][i]) {
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

    public void CreatedItem(Concept_Info concept) {
        GameObject item = Instantiate(item_sample, show_panel.transform);
        item.transform.Find("Text").GetComponent<TMP_Text>().SetText(concept.nickname);
    }

    private void Empty() {
        foreach (Transform obj in show_panel.transform) {
            Destroy(obj.gameObject);
        }
    }
}
