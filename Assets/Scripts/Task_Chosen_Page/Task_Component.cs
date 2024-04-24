using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;

public class Task_Component : MonoBehaviour
{
    public UI_Manager ui_script;  //manager script

    int task_num;  //represented task number
    public TMP_Text num_shown;  //number display object

    //Initialize the setting
    void Start() {
        num_shown = transform.Find("Text").gameObject.GetComponent<TMP_Text>();
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
    }

    //Redirect to task page and set task information
    public void EnterTask() {
        //if user first enter task 0, record first login time
        if (task_num == 0) {
            if (ui_script.GetPlayerFirstTime() == "null") {
                ui_script.SetPlayerTime();
            }
        }

        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("SampleScene");
        ui_script.SetTask(task_num);
    }

    //set number display
    public void SetTaskNum(int num){
        task_num = num;
        transform.Find("Text").gameObject.GetComponent<TMP_Text>().SetText(task_num.ToString());
    }
}
