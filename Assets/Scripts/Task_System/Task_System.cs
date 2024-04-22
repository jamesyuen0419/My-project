using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task_System : MonoBehaviour
{
    public TMP_Text task_content;
    public GameObject character_panel;
    public GameObject character_name_item;
    public GameObject personal_task_panel;
    public GameObject personal_task_item;
    public GameObject personal_task_detail_panel;

    public UI_Manager ui_script;

    public int current_scene;
    public List<String> dialogue;
    public List<List<(int, string)>> character_name;
    int current_character;
    public List<List<List<string>>> task_title;
    public List<List<List<string>>> task_info;
    public List<List<List<List<int>>>> task_hint;

    float speed = 0.03f;
    IEnumerator coroutine;
    bool printing = false;

    void Start()
    {
        task_content = transform.Find("DialogueSystem").Find("Scroll View").Find("Viewport").Find("Content").GetComponent<TMP_Text>();
        character_panel = transform.Find("HintSystem").Find("Character_System").Find("Character").Find("Viewport").Find("Content").gameObject;
        personal_task_panel = transform.Find("HintSystem").Find("Personal_Task_System").Find("Task").Find("Viewport").Find("Content").gameObject;

        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
        current_scene = ui_script.GetSubTaskNum();
        dialogue = ui_script.GetDialogue();
        character_name =ui_script.GetObjectNames();
        (task_title, task_info, task_hint) = ui_script.GetHint();

        UpdateName();
        UpdateContent();
    }

    public void UpdateScene() {
        current_scene += 1;
        UpdateContent();
    }

    void UpdateName() {
        foreach((int num, string name) in character_name[current_scene]) {
            GameObject item = Instantiate(character_name_item, character_panel.transform);
            item.transform.Find("Text").GetComponent<TMP_Text>().SetText(name);
            item.GetComponent<Hint_Character_Name>().sprite_num = num;
        }
    }

    public void NameClickEvent((int, string) val) {
        UpdatePersonalTask(character_name[current_scene].IndexOf(val));
    }

    void UpdatePersonalTask(int num) {
        current_character = num;
        Empty();
        foreach(string title in task_title[num][current_scene]) {
            GameObject item = Instantiate(personal_task_item, personal_task_panel.transform);
            if (title.Length > 20) {
                item.transform.Find("Text").GetComponent<TMP_Text>().SetText(title.Substring(0,17) + "...");
            }
            else {
                item.transform.Find("Text").GetComponent<TMP_Text>().SetText(title);
            }
        }
    }

    private void Empty() {
        foreach (Transform obj in personal_task_panel.transform) {
            Destroy(obj.gameObject);
        }
    }

    public void TaskItemClickEvent(string value) {
        int task_num = task_title[current_character][current_scene].IndexOf(value);

        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
        ui_script.Blur_Screen();
        GameObject panel = Instantiate(personal_task_detail_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
        panel.transform.Find("Scroll View").Find("Viewport").Find("Content").Find("Task_Name").GetComponent<TMP_Text>().SetText(task_title[current_character][current_scene][task_num]);
        panel.transform.Find("Scroll View").Find("Viewport").Find("Content").Find("Task_Description").Find("Viewport").Find("Content").GetComponent<TMP_Text>().SetText(task_info[current_character][current_scene][task_num]);
        string hint_content = ProvideHint(task_num);
        panel.transform.Find("Scroll View").Find("Viewport").Find("Content").Find("Hint_Description").Find("Viewport").Find("Content").GetComponent<TMP_Text>().SetText(hint_content);
    }

    public void UpdateContent() {
        if (printing) {
            StopCoroutine(coroutine);
            
            printing = true;
            task_content.SetText("");
            coroutine = TypeDia();
            StartCoroutine(coroutine);        
        }
        else {
            printing = true;
            task_content.SetText("");
            coroutine = TypeDia();
            StartCoroutine(coroutine);
        }
    }

    IEnumerator TypeDia() {
        foreach (char c in dialogue[current_scene]) {
            task_content.text += c;
            yield return new WaitForSeconds(speed);
        }
        printing = false;
    }

    string ProvideHint(int task_num) {
        string con = "";
        foreach (int num in task_hint[current_character][current_scene][task_num]) {
            switch (num) {
                case 0:
                    con += "- Looping Concept\n";
                    break;
                case 1:
                    con += "- Condition Concept\n";
                    break;
                case 2:
                    con += "- Logic Concept\n";
                    break;
                case 3:
                    con += "- Comparison Concept\n";
                    break;
                case 4:
                    con += "- IfElse Concept\n";
                    break;
                case 5:
                    con += "- Variable Concept\n";
                    break;
                case 6:
                    con += "- Container Concept\n";
                    break;
                case 7:
                    con += "- Action Concept\n";
                    break;
                case 8:
                    con += "- Object Concept\n";
                    break;
                case 9:
                    con += "- Range Concept\n";
                    break;
            }
        }
        return con;
    }
}
