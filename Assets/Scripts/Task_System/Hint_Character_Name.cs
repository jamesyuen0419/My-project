using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hint_Character_Name : MonoBehaviour
{
    public int sprite_num;
    public void NameClickEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.Find("TaskPage").GetComponent<Task_System>().NameClickEvent((sprite_num, transform.Find("Text").GetComponent<TMP_Text>().text));
    }
}
