using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hint_Task_Item : MonoBehaviour
{   
    public void NameClickEvent() {
        GameObject.Find("TaskPage").GetComponent<Task_System>().TaskItemClickEvent(transform.Find("Text").GetComponent<TMP_Text>().text);
    }
}
