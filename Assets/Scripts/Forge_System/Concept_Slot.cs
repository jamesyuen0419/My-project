using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Concept_Slot : MonoBehaviour, IDropHandler
{
    public string main_concept_name;  //main concept name
    public string nickname;  //main concept nickname
    public Concept_Info concept_info;  //main concept information
    public Sprite concept_block_sprite;
    public Sprite action_card_sprite;

    //When concept block or action card drop in the slot, retrieve the type and all the required information
    public void OnDrop(PointerEventData eventData) {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GetComponent<Image>().sprite = eventData.pointerDrag.transform.Find("Icon").GetComponent<Image>().sprite;
        transform.GetComponent<Image>().color = new Color(255,255,225,255);
        if (GetComponent<Image>().sprite == concept_block_sprite) {
            Draggable_Concept con = eventData.pointerDrag.transform.GetComponent<Draggable_Concept>();
            main_concept_name = con.concept_name;
            if (main_concept_name == "Action" || main_concept_name == "Object") {
                nickname = con.concept_info.nickname;
            }
            else {
                nickname = main_concept_name;
            }
            concept_info = con.concept_info;
        }
        else {
            Combined_Action_Card con = eventData.pointerDrag.transform.GetComponent<Combined_Action_Card>();
            nickname = con.concept_info.nickname;
            main_concept_name = con.concept_name;
            concept_info = con.concept_info;
        }

        //If name too long, retrieve the substring only
        if (nickname.Length > 15) {
            GameObject.FindGameObjectWithTag("forge_concept_system").GetComponent<Forge_System>().InsertMain(nickname.Substring(0,12) + "...");
        }
        else
        {
            GameObject.FindGameObjectWithTag("forge_concept_system").GetComponent<Forge_System>().InsertMain(nickname);
        }
    }

    //Clear the concept information
    public void Clear() {
        main_concept_name = "";
        nickname = "";
        concept_info = null;
    }
}
