using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rename_System : MonoBehaviour
{
    public GameObject forge_panel;  //forge panel
    public GameObject forge_concept_system;  //forge system
    public GameObject inputfield;  //input field for name
    public string card_name;  //name of the card
    public string concept_name;  //concept name

    //Initialize the setting
    void Start()
    {
        forge_panel = GameObject.FindGameObjectWithTag("forge_panel");
        forge_concept_system = GameObject.FindGameObjectWithTag("forge_concept_system");
        card_name = forge_panel.GetComponent<Forge_Panel_System>().nickname;
        concept_name = forge_panel.GetComponent<Forge_Panel_System>().main_concept_name;
        inputfield = transform.Find("InputField").gameObject;
        inputfield.transform.GetComponent<TMP_InputField>().text = card_name;
    }

    //Cancel the rename process
    public void CancelButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.Find("Forge_Panel").GetComponent<Forge_Panel_System>().UnBlur_Panel();
        Destroy(gameObject);
    }

    //Confirm the rename process
    public void ConfirmButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (inputfield.GetComponent<TMP_InputField>().text.Trim() != "") {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(5);
            //unblur all the layer of blur panel
            GameObject.Find("Forge_Panel").GetComponent<Forge_Panel_System>().UnBlur_Panel();
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().UnBlur_Screen();
            //combine the card with update information and add it to the backpack
            Concept_Info info = forge_panel.GetComponent<Forge_Panel_System>().GetInfo();
            card_name = inputfield.GetComponent<TMP_InputField>().text;
            info.nickname = card_name;
            Combined_Card_Info newCardInfo = new Combined_Card_Info(card_name, concept_name, info);
            forge_concept_system.GetComponent<Forge_System>().AddCombinedCard(newCardInfo);
            //clear all the panel and concept on the forge system
            Destroy(forge_panel);
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("forge_concept_system").GetComponent<Forge_System>().ClearButtonEvent();
        }
    }
}
