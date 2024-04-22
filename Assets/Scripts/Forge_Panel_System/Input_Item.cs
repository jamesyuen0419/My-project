using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Input_Item : MonoBehaviour
{
    GameObject panel;  //forge panel
    GameObject type;  //name of the type
    GameObject field; //input field

    //Initialize the setting
    void Start() {
        panel = GameObject.FindGameObjectWithTag("forge_panel");
        type = transform.Find("Input_Type").gameObject;
        field = transform.Find("InputField").gameObject;
    }

    //Update the information of certain item
    public void GetStringInput(string str) {
        panel.GetComponent<Forge_Panel_System>().UpdateType2(field.GetComponent<TMP_InputField>().text, type.GetComponent<TMP_Text>().text);
    }
}
