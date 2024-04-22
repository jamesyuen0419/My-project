using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrong_Main_Concept : MonoBehaviour
{
    //Close the notification panel
    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().UnBlur_Screen();
        Destroy(gameObject);
    }
}
