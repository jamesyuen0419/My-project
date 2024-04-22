using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;

public class Task_Component : MonoBehaviour
{
    public UI_Manager ui_script;

    int task_num;
    public TMP_Text num_shown;

    void Start() {
        num_shown = transform.Find("Text").gameObject.GetComponent<TMP_Text>();
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
    }

    public void EnterTask() {
        if (task_num == 0) {
            if (ui_script.GetPlayerFirstTime() == "null") {
                ui_script.SetPlayerTime();
            }
        }

        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("SampleScene");
        ui_script.SetTask(task_num);
    }

    public void SetTaskNum(int num){
        task_num = num;
        transform.Find("Text").gameObject.GetComponent<TMP_Text>().SetText(task_num.ToString());
    }
}
