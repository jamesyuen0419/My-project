using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Forge_System : MonoBehaviour
{
    public GameObject main_slot;  //main concept slot in forge system
    public GameObject support_slot;  //support concept slot in forge system
    public GameObject forge_panel;  //prefab of forge panel
    public GameObject wrong_panel;  //prefab of wrong panel
    public TMP_Text main_con;  //main concept name display
    public TMP_Text support_con;  //support concept name display

    public Sprite blank_icon;  //empty concept slot sprite
    public UI_Manager ui_script;  //manager script

    string nickname;  //main concept nickname
    string main_concept_name;  //main concept name
    public Concept_Info main_concept_info;  // main concept information
    string support_concept_name;  //support concept name
    public Concept_Info support_concept_info;  //support concept information

    //Initialize the setting
    void Start()
    {
        main_slot = gameObject.transform.Find("Main_Concept_Slot").gameObject;
        support_slot = gameObject.transform.Find("Support_Concept_Slot").gameObject;
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
        main_con = transform.Find("Main_Name").Find("Text").GetComponent<TMP_Text>();
        support_con = transform.Find("Support_Name").Find("Text").GetComponent<TMP_Text>();
    }

    //Start the forge process
    public void ForgeButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        string check = null;
        //check main concept slot's concept name
        if (main_slot.GetComponent<Concept_Slot>().concept_info != null) {
            check = main_slot.GetComponent<Concept_Slot>().concept_info.concept_name;
        }
        //check if main concept slot is empty or not
        if (main_slot.GetComponent<Image>().sprite == null) {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            ui_script.Blur_Screen();
            //call wrong panel and its content
            GameObject panel = Instantiate(wrong_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
            panel.transform.Find("Text").GetComponent<TMP_Text>().SetText("Empty Main Concept!");
        }
        else if (check == "Logic" || check == "Action" || check == "Object") {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            ui_script.Blur_Screen();
            //call wrong panel when user modify concept that are not allowed to modify
            GameObject panel = Instantiate(wrong_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
            panel.transform.Find("Text").GetComponent<TMP_Text>().SetText("This Main Concept cannot be modified!");
        }
        else {
            //retrieve all data from concept slots
            nickname = main_slot.GetComponent<Concept_Slot>().nickname;
            main_concept_name = main_slot.GetComponent<Concept_Slot>().main_concept_name;
            main_concept_info = main_slot.GetComponent<Concept_Slot>().concept_info;
            support_concept_name = support_slot.GetComponent<Concept_Slot_Support>().support_concept_name;
            support_concept_info = support_slot.GetComponent<Concept_Slot_Support>().concept_info;

            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            ui_script.Blur_Screen();
            //call forge panel and transfer data
            GameObject panel = Instantiate(forge_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
            Forge_Panel_System sys = panel.GetComponent<Forge_Panel_System>();
            sys.UpdateContent(nickname, main_concept_name,support_concept_name,main_concept_info,support_concept_info, gameObject);
        }
    }

    //Add card information into storage
    public void AddCombinedCard(Combined_Card_Info card) {
        ui_script.AddToPackPack(card);
    }

    //Empty all information store in the slots and their sprite
    public void ClearButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        main_slot.GetComponent<Image>().sprite = blank_icon;
        main_slot.transform.GetComponent<Image>().color = new Color(255,255,225,0);
        support_slot.GetComponent<Image>().sprite = blank_icon;
        support_slot.transform.GetComponent<Image>().color = new Color(255,255,225,0);
        main_concept_name = "";
        main_concept_info = null;
        support_concept_name = "";
        support_concept_info = null;
        main_slot.GetComponent<Concept_Slot>().Clear();
        support_slot.GetComponent<Concept_Slot_Support>().Clear();
        main_con.SetText("None");
        support_con.SetText("None");
    }

    //Display main concept name
    public void InsertMain(string name) {
        main_con.SetText(name);
    }

    //Display support concept name
    public void InsertSupport(string name) {
        support_con.SetText(name);
    }
}
