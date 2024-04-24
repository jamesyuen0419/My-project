using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Search_System : MonoBehaviour
{
    public GameObject item;  //shown item
    public GameObject blank_item;  //prefab of blank item
    public GameObject function_image;  //current mode sprite shown

    public UI_Manager ui_script;  //manager script

    public GameObject search_function_panel;
    public GameObject dropdown;  //dropdown menu
    public TMP_Dropdown dropdownObj;  //current dropdown object

    public GameObject action_card_function_panel;

    public GameObject detective_function_panel;
    public GameObject detective_panel;  //prefab of detective panel

    public GameObject item_panel;

    public int systemMode = 1;  //current system mode
    public int pos = 0;  //current item number
    public int function_pos = 0;  //current function number

    public List<Sprite> function_sprites;  //function sprite list

    public List<Action_Info> task_action;  //action concept list
    public List<Object_Info> task_object;  //object concept list
    public List<Combined_Card_Info> action_cards;  //action card list
    public List<string> concept_names;  //concept name list

    public GameObject concept_block;  //prefab of concept block
    public GameObject action_card;  //prefab of action card

    //Initialize the setting
    void Start()
    {
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
        (task_action, task_object) = ui_script.GetActionAndObject();
        concept_names = ui_script.SearchButtonDatabase(0);
        action_cards = ui_script.GetCards();
        function_pos = 0;

        function_image = transform.Find("Change_Function_Panel").Find("Function_Image").gameObject;
        function_image.GetComponent<Image>().sprite = function_sprites[function_pos];

        search_function_panel = transform.Find("Function_Panel").Find("Search_Function").gameObject;
        dropdown = search_function_panel.transform.Find("Concept_Dropdown").gameObject;
        dropdownObj = dropdown.GetComponent<TMP_Dropdown>();

        action_card_function_panel = transform.Find("Function_Panel").Find("Action_Card_Function").gameObject;

        detective_function_panel = transform.Find("Function_Panel").Find("Detective_Function").gameObject;

        item_panel = transform.Find("Item_Panel").gameObject;
        item = item_panel.transform.Find("Concept_Item").gameObject;

        ChangeFunctionMode();
    }

    //Control to the previous function
    public void FunctionLeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (function_pos > 0) {
            function_pos -= 1;
            ChangeFunctionMode();
        }
    }

    //Control to the next function
    public void FunctionRightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (function_pos < 2) {
            if (function_pos + 1 == 2) {
                if (ui_script.GetTaskCompleted() > 9) {
                    function_pos += 1;
                    ChangeFunctionMode();
                }
            }
            else {
                function_pos += 1;
                ChangeFunctionMode();
            }
        }
    }

    //Mode chosen function
    void ChangeFunctionMode() {
        function_image.GetComponent<Image>().sprite = function_sprites[function_pos];
        switch (function_pos) {
            case 0:
                ConceptButtonEvent();
                break;
            case 1:
                BackpackButtonEvent();
                break;
            case 2:
                DetectiveButtonEvent();
                break;
        }
    }

    //Concept mode setting
    public void ConceptButtonEvent() {
        search_function_panel.SetActive(true);
        action_card_function_panel.SetActive(false);
        detective_function_panel.SetActive(false);
        systemMode = 1;
        item_panel.transform.Find("Concept_Search_Left_Button").gameObject.SetActive(true);
        item_panel.transform.Find("Concept_Search_Right_Button").gameObject.SetActive(true);
        item.SetActive(true);
        pos = 0;
        GameObject o1;
        o1 = Instantiate(blank_item, item_panel.transform);
        o1.transform.position = item.transform.position;
        Destroy(item);
        item = o1;

    }

    //Backpack mode setting
    public void BackpackButtonEvent() {
        search_function_panel.SetActive(false);
        action_card_function_panel.SetActive(true);
        detective_function_panel.SetActive(false);
        systemMode = 2;
        item_panel.transform.Find("Concept_Search_Left_Button").gameObject.SetActive(true);
        item_panel.transform.Find("Concept_Search_Right_Button").gameObject.SetActive(true);
        item.SetActive(true);
        pos = 0;
        action_cards = ui_script.GetCards();
        CreateActionCard();
    }

    //Detective mode setting
    public void DetectiveButtonEvent() {
        search_function_panel.SetActive(false);
        action_card_function_panel.SetActive(false);
        detective_function_panel.SetActive(true);
        systemMode = 3;
        item_panel.transform.Find("Concept_Search_Left_Button").gameObject.SetActive(false);
        item_panel.transform.Find("Concept_Search_Right_Button").gameObject.SetActive(false);
        item.SetActive(false);
    }

    //Call the detective panel
    public void OpenDetectiveButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
        ui_script.Blur_Screen();
        GameObject panel = Instantiate(detective_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
    }

    //Show current action card information
    public void ActionInfoButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
        if (action_cards.Count > 0) {
            item.GetComponent<Combined_Action_Card>().ShowInfo();
        }
    }

    //Delete current action card
    public void DeleteActionButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (action_cards.Count > 0) {
            if (pos > 0) {
                pos -= 1;
                ui_script.RemoveFromPackPack(pos + 1);
            }
            else {
                ui_script.RemoveFromPackPack(pos);
            }
        }
    }

    //Control to the previous concept
    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (systemMode == 1) {
            if (pos > 0 && concept_names != null) {
                pos  -= 1;
                Addinfo(true);
            }    
        }
        else {
            if (pos > 0 && action_cards != null) {
                pos  -= 1;
                Addinfo(false);
            }
        }
    }

    //Control to the next concept
    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (systemMode == 1) {
            if (pos < concept_names.Count - 1 && concept_names != null) {
                pos += 1;
                Addinfo(true);
            }    
        }
        else {
            if (pos < action_cards.Count - 1 && action_cards != null) {
                pos += 1;
                Addinfo(false);
            }
        }
    }

    //Search process of certain type of concept
    public void SearchButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        pos = 0;
        int concept_number = dropdownObj.value;
        //action and object concept are stored in this system, no need to perform database search
        if (concept_number == 7) {
            concept_names.Clear();
            for (int i = 0; i < task_action.Count; i++) {
                concept_names.Add("Action");
            }
            if (task_action.Count > 0) {
                CreateConceptBlock();
            }
        }
        else if (concept_number == 8) {
            concept_names.Clear();
            for (int i = 0; i < task_object.Count; i++) {
                concept_names.Add("Object");
            }
            if (task_object.Count > 0) {
                CreateConceptBlock();
            }
        }
        else {
            concept_names = ui_script.SearchButtonDatabase(concept_number);
            CreateConceptBlock();
        }
    }

    //Create concept block to replace current item
    private void CreateConceptBlock() {
        GameObject o1;
        o1 = Instantiate(concept_block, item_panel.transform);
        o1.name = o1.name.Replace("(Clone)","").Trim();
        o1.transform.position = item.transform.position;
        Destroy(item);
        item = o1;
        Addinfo(true);
    }

    //Create action card to replace current item
    private void CreateActionCard() {
        GameObject o1;
        if (action_cards.Count == 0) {
            o1 = Instantiate(blank_item, item_panel.transform);
        }
        else {
            o1 = Instantiate(action_card, item_panel.transform);
            o1.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(action_cards[pos].nickname);
        }
        o1.name = o1.name.Replace("(Clone)","").Trim();
        o1.transform.position = item.transform.position;
        Destroy(item);
        item = o1;
        if (action_cards.Count > 0) {
            Addinfo(false);
        }
    }

    //Initialize concept block information 
    private void Addinfo(bool type) {
        if (type) {
            Draggable_Concept con = item.GetComponent<Draggable_Concept>();
            con.concept_name = concept_names[pos];
            switch (concept_names[pos])
            {
                case "Looping":
                    con.concept_info = new Looping_Info(null,null,null,null);
                    break;
                case "Condition":
                    con.concept_info = new Condition_Info(null);
                    break;
                case "Range":
                    con.concept_info = new Range_Info(0, 0, 0);
                    break;
                case "Range_Var":
                    con.concept_info = new RangeVar_Info(null,null,null);
                    break;
                case "True":
                    con.concept_info = new Logic_Info("T");
                    break;
                case "False":
                    con.concept_info = new Logic_Info("F");
                    break;
                case "And":
                    con.concept_info = new Logic_Info("&");
                    break;
                case "Or":
                    con.concept_info = new Logic_Info("|");
                    break;
                case "Larger":
                    con.concept_info = new Logic_Info(">");
                    break;
                case "Smaller":
                    con.concept_info = new Logic_Info("<");
                    break;
                case "Equal":
                    con.concept_info = new Logic_Info("==");
                    break;
                case "Not Equal":
                    con.concept_info = new Logic_Info("!=");
                    break;
                case "Comparison":
                    con.concept_info = new Comparison_Info(null,null,null);
                    break;
                case "IfStatement":
                    con.concept_info = new If_Statement_Info(null,null);
                    break;
                case "Variable":
                    con.concept_info = new Variable_Info(null,null); 
                    break;
                case "Container":
                    con.concept_info = new Container_Info(null);
                    break;
                case "Action":
                    con.concept_info = task_action[pos]; 
                    break;
                case "Object":
                    con.concept_info = task_object[pos];
                    break;
                case "Provided Stuff":
                    con.concept_info = null;
                    break;
            }

            con.concept_info.nickname = con.concept_name;

            //substring when name length out of range
            if (con.concept_name == "Action") {
                if (task_action[pos].action.Length > 20) {
                    item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(task_action[pos].action.Substring(0,17) + "...");
                }
                else {
                    item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(task_action[pos].action);
                }
                con.concept_info.nickname = task_action[pos].action;
            }
            else if (con.concept_name == "Object") {
                if (task_object[pos].object_name.Length > 20) {
                    item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(task_object[pos].object_name.Substring(0,17) + "...");
                }
                else {
                    item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(task_object[pos].object_name);
                }
                con.concept_info.nickname = task_object[pos].object_name;
            }
            else {
                if (concept_names[pos].Length > 20) {
                    item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(concept_names[pos].Substring(0,17) + "...");
                }
                else {
                    item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(concept_names[pos]);
                }
            }
        }
        else {
            Combined_Action_Card act = item.GetComponent<Combined_Action_Card>();
            act.concept_name = action_cards[pos].concept_name;
            act.concept_info = action_cards[pos].concept_info;
            act.concept_info.nickname = action_cards[pos].nickname;
            //substring when name length out of range
            if (action_cards[pos].nickname.Length > 20) {
                item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(action_cards[pos].nickname.Substring(0,17) + "...");
            }
            else {
                item.transform.Find("Concept_Name").GetComponent<TMP_Text>().SetText(action_cards[pos].nickname);
            }
        }

    }

    //Reload the action card shown
    public void UpdateCards() {
        action_cards = ui_script.GetCards();
        if (systemMode == 2) {
            if (pos < 0) {
                pos = 0;
            }
            CreateActionCard();
        }
    }
}
