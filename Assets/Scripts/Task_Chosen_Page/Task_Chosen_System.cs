using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task_Chosen_System : MonoBehaviour
{
    public GameObject container;
    public GameObject task_component;
    public int task_total = 20;
    public int task_completed = -1;
    public int current_head = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        container = transform.Find("Task_Container").gameObject;
        //task_completed = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().GetTaskCompleted();
        task_completed = 20;
        CreateTaskBlock();
    }

    private void CreateTaskBlock() {
        Empty();
        int block_created = 0;

        if (task_completed == -1) {
            //task_completed = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().GetTaskCompleted();
            task_completed = 20;
        }

        for (int i = current_head; i < task_total; i++) {
            if (block_created == 6) {
                break;
            }

            GameObject com = Instantiate(task_component, container.transform);
            com.name = com.name.Replace("(Clone)","").Trim();
            com.GetComponent<Task_Component>().SetTaskNum(i);
            if (i > task_completed) {
                com.GetComponent<Button>().interactable = false;
            }

            block_created +=1;
        }
    }

    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_head - 6 >= 0) {
            current_head -= 6;
            CreateTaskBlock();
        }
    }

    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_head + 6 < task_total) {
            current_head += 6;
            CreateTaskBlock();
        }
    }

    private void Empty() {
        foreach (Transform child in container.transform) {
            Destroy(child.gameObject);
        }
    }
}
