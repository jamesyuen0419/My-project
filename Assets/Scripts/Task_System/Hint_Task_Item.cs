using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hint_Task_Item : MonoBehaviour
{   
    //call the hint panel using task system
    public void NameClickEvent() {
        GameObject.Find("TaskPage").GetComponent<Task_System>().TaskItemClickEvent(transform.Find("Text").GetComponent<TMP_Text>().text);
    }
}
