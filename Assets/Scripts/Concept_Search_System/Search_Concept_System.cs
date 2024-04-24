using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Search_Concept_System : MonoBehaviour
{
    public GameObject title_switch; //cover page
    public TMP_Text concept_title;  //title of concept

    public GameObject title_image;  //game object of image
    public GameObject image; //image of concept

    public GameObject concept_info; //inner description panel
    public ScrollRect scroll_view; //scroll view for description
    public GameObject concept_description; //scroll view content for description
    public GameObject concept_name; //name of current concept part

    public UI_Manager ui_script; //manager script

    private int current_page;  //cover page number
    private int current_inner_page; //description page number
    private List<string> concept_titles; //list of concept name
    private List<string> concept_inner_titles;  //list of concept part name
    private List<Sprite> concept_sprites;  //list of concept sprite

    //Initialize all the setting
    void Start()
    {
        title_switch = gameObject.transform.Find("Main_Monitor").Find("Title_Switch").gameObject;
        concept_title = title_switch.transform.Find("Concept_Title").gameObject.GetComponent<TMP_Text>();

        title_image = gameObject.transform.Find("Main_Monitor").Find("Title_Image").gameObject;
        image = title_image.transform.Find("Image_Icon").gameObject;

        concept_info = gameObject.transform.Find("Main_Monitor").Find("Concept_Info").gameObject;
        concept_name = concept_info.transform.Find("Concept_Name").gameObject;
        scroll_view = concept_info.transform.Find("Scroll View").GetComponent<ScrollRect>();
        concept_description = concept_info.transform.Find("Scroll View").Find("Viewport").Find("Content").gameObject;

        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();

        current_page = 0;
        current_inner_page = 0;
        concept_titles = ui_script.GetConceptNames();
        concept_title.SetText(concept_titles[current_page]);
        concept_sprites = ui_script.GetConceptSprites();
        image.GetComponent<Image>().sprite = concept_sprites[current_page];

        title_switch.SetActive(true);
        title_image.SetActive(true);
        concept_info.SetActive(false);
    }

    //Control to the previous concept
    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_page > 0) {
            current_page -= 1;
            concept_title.SetText(concept_titles[current_page]);
            image.GetComponent<Image>().sprite = concept_sprites[current_page];
        }
    }

    //Control to the next concept
    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_page < concept_titles.Count - 1) {
            current_page += 1;
            concept_title.SetText(concept_titles[current_page]);
            image.GetComponent<Image>().sprite = concept_sprites[current_page];
        }
    }

    //button to enter the description page
    public void IconButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        title_switch.SetActive(false);
        title_image.SetActive(false);
        concept_info.SetActive(true);
        concept_inner_titles = ui_script.GetInnerConceptNames(current_page);
        current_inner_page = 0;

        string name;
        string description;
        (name, description) = ui_script.GetConceptInfo(current_page, current_inner_page);
        concept_name.transform.GetComponent<TMP_Text>().SetText(name);
        concept_description.transform.GetComponent<TMP_Text>().SetText(description);
    }

    //button to go back to cover page
    public void BackButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        title_switch.SetActive(true);
        title_image.SetActive(true);
        concept_info.SetActive(false);
    }

    //Control to the previous concept description
    public void LeftButton2Event() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_inner_page > 0) {
            current_inner_page -= 1;
            string name;
            string description;
            (name, description) = ui_script.GetConceptInfo(current_page, current_inner_page);
            concept_name.transform.GetComponent<TMP_Text>().SetText(name);
            concept_description.transform.GetComponent<TMP_Text>().SetText(description);
            scroll_view.verticalNormalizedPosition = 1f;
        }
    }

    //Control to the next concept description
    public void RightButton2Event() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_inner_page < concept_inner_titles.Count - 1) {
            current_inner_page += 1;
            string name;
            string description;
            (name, description) = ui_script.GetConceptInfo(current_page, current_inner_page);
            concept_name.transform.GetComponent<TMP_Text>().SetText(name);
            concept_description.transform.GetComponent<TMP_Text>().SetText(description);
            scroll_view.verticalNormalizedPosition = 1f;
        }
    }
}
