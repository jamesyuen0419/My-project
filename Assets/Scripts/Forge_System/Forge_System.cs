using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Forge_System : MonoBehaviour
{
    public GameObject main_slot;
    public GameObject support_slot;
    public GameObject forge_button;
    public GameObject clear_button;
    public GameObject forge_panel;
    public GameObject wrong_panel;
    public TMP_Text main_con;
    public TMP_Text support_con;

    public Sprite action_icon;
    public Sprite blank_icon;
    public UI_Manager ui_script;

    String nickname;
    String main_concept_name;
    public Concept_Info main_concept_info;
    String support_concept_name;
    public Concept_Info support_concept_info;

    void Start()
    {
        main_slot = gameObject.transform.Find("Main_Concept_Slot").gameObject;
        support_slot = gameObject.transform.Find("Support_Concept_Slot").gameObject;
        forge_button = gameObject.transform.Find("Forge_Button ").gameObject;
        clear_button = gameObject.transform.Find("Clear_Button").gameObject;
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
        main_con = transform.Find("Main_Name").Find("Text").GetComponent<TMP_Text>();
        support_con = transform.Find("Support_Name").Find("Text").GetComponent<TMP_Text>();
    }

    public void ForgeButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        string check = null;
        if (main_slot.GetComponent<Concept_Slot>().concept_info != null) {
            check = main_slot.GetComponent<Concept_Slot>().concept_info.concept_name;
        }
        if (main_slot.GetComponent<Image>().sprite == null) {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            ui_script.Blur_Screen();
            GameObject panel = Instantiate(wrong_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
            panel.transform.Find("Text").GetComponent<TMP_Text>().SetText("Empty Main Concept!");
        }
        else if (check == "Logic" || check == "Action" || check == "Object") {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            ui_script.Blur_Screen();
            GameObject panel = Instantiate(wrong_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
            panel.transform.Find("Text").GetComponent<TMP_Text>().SetText("This Main Concept cannot be modified!");
        }
        else {
            nickname = main_slot.GetComponent<Concept_Slot>().nickname;
            main_concept_name = main_slot.GetComponent<Concept_Slot>().main_concept_name;
            main_concept_info = main_slot.GetComponent<Concept_Slot>().concept_info;
            support_concept_name = support_slot.GetComponent<Concept_Slot_Support>().support_concept_name;
            support_concept_info = support_slot.GetComponent<Concept_Slot_Support>().concept_info;

            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            ui_script.Blur_Screen();
            GameObject panel = Instantiate(forge_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
            Forge_Panel_System sys = panel.GetComponent<Forge_Panel_System>();
            sys.UpdateContent(nickname, main_concept_name,support_concept_name,main_concept_info,support_concept_info, gameObject);
        }
    }

    public void AddCombinedCard(Combined_Card_Info card) {
        ui_script.AddToPackPack(card);
    }

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

    public void InsertMain(string name) {
        main_con.SetText(name);
    }

    public void InsertSupport(string name) {
        support_con.SetText(name);
    }
}
