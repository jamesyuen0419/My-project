using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Forge_Panel_System : MonoBehaviour
{
    public string main_concept_name;  //main concept name
    public string support_concept_name;  //support concept name
    public Concept_Info main_concept_info;  //main concept information
    public Concept_Info support_concept_info; //support concept information

    public GameObject transfer_button;  //button to transfer concept between two lists
    public GameObject forge_concept_system;  //forge system

    public GameObject rename_panel;  //prefab of rename panel
    public GameObject error_panel;  //prefab of error panel
    public GameObject blur_panel;  //prefab of blur panel
    public string nickname;  //main concept nickname

    public GameObject selected_item;  //selected object
    public int selected_index;  //selected object index
    public bool selected_IsInList; //whether the selected object is in the main concept list

    public GameObject mainConceptContainer;  //main concept list
    public GameObject mainConcept;  //main concept list title
    public GameObject mainConceptList;  //main concept list content
    public GameObject itemSample;  //prefab of object item
    public GameObject mainConcept2Container;  //main concept list for type information item
    public GameObject mainConceptList2;  //main concept list content for type information item
    public GameObject itemSample2;  //prefab of type information item

    public GameObject supportConcept;  //support concept list title
    public GameObject supportConceptList;  //support concept list

    public List<int> childlimit;  //child object restriction on each page
    public List<int> mode;  //mode of each page
    public int pageLimit;  //number of page
    public int currentPage;  //current page number
    public int currentChild = 0;  //child number
    public Concept_Info current_info;  //combined concept information
    public List<string> Region_names;  //name of different page
    public Dictionary<string, string> listType2Value;  //list to store main list information for type 2
    public List<List<Concept_Info>> listType1Value;  //list to store main list information for type 1

    //Initialize the setting
    void Start() {
        mainConcept = transform.Find("Main_Concept").gameObject;
        mainConcept.GetComponent<TMP_Text>().SetText(main_concept_name);
        mainConceptContainer = GameObject.FindGameObjectWithTag("concept_adjust_list");
        mainConceptList = GameObject.FindGameObjectWithTag("concept_adjust_list").transform.Find("Viewport").Find("Content").gameObject;
        mainConcept2Container = GameObject.FindGameObjectWithTag("concept_adjust_list_2");
        mainConceptList2 = GameObject.FindGameObjectWithTag("concept_adjust_list_2").transform.Find("Viewport").Find("Content").gameObject;
        supportConcept = transform.Find("Support_Concept").gameObject;
        supportConceptList = GameObject.FindGameObjectWithTag("support_concept_list").transform.Find("Viewport").Find("Content").gameObject;
        transfer_button = transform.Find("Transfer_Button").gameObject;

        selected_item = null;
        currentPage = 0;
        listType2Value = new Dictionary<string, string>();
        listType1Value = new List<List<Concept_Info>>();

        UpdateAdjustList();
        UpdateSupportList();
    }

    //Update the information
    public void UpdateContent(string nn, string mc, string sc, Concept_Info mac, Concept_Info sac, GameObject system) {
        nickname = nn;
        main_concept_name = mc;
        support_concept_name = sc;
        main_concept_info = mac;
        support_concept_info = sac;
        forge_concept_system = system;
    }

    //Update the setting and information of the panel according to concept type
    public void UpdateAdjustList() {
        switch (main_concept_name) {
            case "Condition":
                Region_names = new List<string> {"Condition"};
                childlimit = new List<int> {1};
                mode = new List<int> {1};
                pageLimit = 1;
                if (((Condition_Info) main_concept_info).condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((Condition_Info) main_concept_info).condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Range":
                Region_names = new List<string> {"Range"};
                childlimit = new List<int> {0};
                mode = new List<int> {0};
                pageLimit = 1;
                listType2Value = new Dictionary<string, string>
                {
                    { "Start", ((Range_Info)main_concept_info).start.ToString()},
                    { "End", ((Range_Info)main_concept_info).end.ToString()},
                    { "Interval", ((Range_Info)main_concept_info).interval.ToString()}
                };
                listType1Value = null;
                break;
            case "Range_Var":
                Region_names = new List<string> {"Start", "End", "Interval"};
                childlimit = new List<int> {1,1,1};
                mode = new List<int> {1,1,1};
                pageLimit = 3;
                if (((RangeVar_Info) main_concept_info).start != null) {
                    listType1Value.Add(new List<Concept_Info> {((RangeVar_Info) main_concept_info).start});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((RangeVar_Info) main_concept_info).end != null) {
                    listType1Value.Add(new List<Concept_Info> {((RangeVar_Info) main_concept_info).end});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((RangeVar_Info) main_concept_info).interval != null) {
                    listType1Value.Add(new List<Concept_Info> {((RangeVar_Info) main_concept_info).interval});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Container":
                Region_names = new List<string> {"Contained Item"};
                childlimit = new List<int> {-1};
                mode = new List<int> {1};
                pageLimit = 1;
                if (((Container_Info) main_concept_info).contained_items != null) {
                    listType1Value.Add(((Container_Info) main_concept_info).contained_items);
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "IfStatement":
                Region_names = new List<string> {"Condition", "Result"};
                childlimit = new List<int> {1,-1};
                mode = new List<int> {1,1};
                pageLimit = 2;
                if (((If_Statement_Info) main_concept_info).condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((If_Statement_Info) main_concept_info).condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((If_Statement_Info) main_concept_info).results != null) {
                    listType1Value.Add(((If_Statement_Info) main_concept_info).results);
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Looping":
                Region_names = new List<string> {"Condition", "Action", "Break Condition", "Continue Condition"};
                childlimit = new List<int> {1,-1,1,1};
                mode = new List<int> {1,1,1,1};
                pageLimit = 4;
                if (((Looping_Info) main_concept_info).condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((Looping_Info) main_concept_info).condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Looping_Info) main_concept_info).actions != null) {
                    listType1Value.Add(((Looping_Info) main_concept_info).actions);
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Looping_Info) main_concept_info).break_condition != null) {
                   listType1Value.Add(new List<Concept_Info> {((Looping_Info) main_concept_info).break_condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Looping_Info) main_concept_info).continue_condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((Looping_Info) main_concept_info).continue_condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Variable":
                Region_names = new List<string> {"Info"};
                childlimit = new List<int> {0};
                mode = new List<int> {0};
                pageLimit = 1;
                listType2Value = new Dictionary<string, string>();
                if (((Variable_Info) main_concept_info).variable_type == null) {
                    listType2Value.Add("Type", "");
                }
                else {
                    listType2Value.Add("Type", ((Variable_Info) main_concept_info).variable_type);
                }
                if (((Variable_Info) main_concept_info).variable_type == null) {
                    listType2Value.Add("Value", "");
                }
                else {
                    listType2Value.Add("Value", ((Variable_Info) main_concept_info).variable_name);
                }
                listType1Value = null;
                break;
            case "Comparison":
                Region_names = new List<string> {"Object 1", "Operator", "Object 2"};
                childlimit = new List<int> {1,1,1};
                mode = new List<int> {1,1,1};
                pageLimit = 3;
                if (((Comparison_Info) main_concept_info).objA != null) {
                    listType1Value.Add(new List<Concept_Info> {((Comparison_Info) main_concept_info).objA});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Comparison_Info) main_concept_info).sym != null) {
                    listType1Value.Add(new List<Concept_Info> {((Comparison_Info) main_concept_info).sym});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Comparison_Info) main_concept_info).objB != null) {
                    listType1Value.Add(new List<Concept_Info> {((Comparison_Info) main_concept_info).objB});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
        }

        PrintAdjustList();
    }

    //Create object for support concept
    public void UpdateSupportList() {
        if (support_concept_name != "") {
            CreatedItem(support_concept_info, false);
        }
    }

    //Print the main concept list
    public void PrintAdjustList() {
        mainConcept.GetComponent<TMP_Text>().SetText(Region_names[currentPage]);
        if (mode[currentPage] == 0) {
            transfer_button.SetActive(false);
            mainConceptContainer.SetActive(false);
            mainConcept2Container.SetActive(true);
            Empty(0);
            foreach(KeyValuePair<string, string> pair in listType2Value){
                CreatedItem2(pair.Key, pair.Value);
            }
        }
        else if (mode[currentPage] == 1) {
            transfer_button.SetActive(true);
            mainConceptContainer.SetActive(true);
            mainConcept2Container.SetActive(false);
            Empty(1);
            if (listType1Value[currentPage].Count > 0) {
                currentChild = listType1Value[currentPage].Count;
                foreach(Concept_Info concept in listType1Value[currentPage]) {
                    CreatedItem(concept, true);
                }
            } 
        }
    }

    //Update the selected item
    public void Selected(GameObject item, bool isInList, int index) {
        selected_item = item;
        selected_IsInList = isInList;
        selected_index = index;
    }

    //Combine the concept together according to the type of concept
    public void CombineButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        //if concept combination return error, it means user perform the wrong combination
        try{
            Concept_Info newCardConcept = null;
            switch (main_concept_name) {
                case "Condition":
                    Concept_Info condition;
                    if (listType1Value[0].Count == 0) {
                        condition = null;
                    }
                    else {
                        condition = listType1Value[0][0];
                    }
                    newCardConcept = new Condition_Info(condition);
                    break;
                case "Container":
                    newCardConcept = new Container_Info(listType1Value[0]);
                    break;
                case "Range":
                    newCardConcept = new Range_Info(int.Parse(listType2Value["Start"]), int.Parse(listType2Value["End"]), float.Parse(listType2Value["Interval"]));
                    break;
                case "Range_Var":
                    Concept_Info var_start;
                    if (listType1Value[0].Count == 0) {
                        var_start = null;
                    }
                    else {
                        var_start = listType1Value[0][0];
                    }
                    Concept_Info var_end;
                    if (listType1Value[1].Count == 0) {
                        var_end = null;
                    }
                    else {
                        var_end = listType1Value[1][0];
                    }
                    Concept_Info var_interval;
                    if (listType1Value[2].Count == 0) {
                        var_interval = null;
                    }
                    else {
                        var_interval = listType1Value[2][0];
                    }
                    newCardConcept = new RangeVar_Info(var_start,var_end,var_interval);
                    break;
                case "IfStatement":
                    Condition_Info condtainer_con;
                    if (listType1Value[0].Count == 0) {
                        condtainer_con = null;
                    }
                    else {
                        condtainer_con = (Condition_Info)listType1Value[0][0];
                    }
                    newCardConcept = new If_Statement_Info(condtainer_con, listType1Value[1]);
                    break;
                case "Looping":
                    Concept_Info con;
                    Condition_Info breaks;
                    Condition_Info continues;
                    if (listType1Value[0].Count == 0) {
                        con = null;
                    }
                    else {
                        con = listType1Value[0][0];
                    }
                    if (listType1Value[2].Count == 0) {
                        breaks = null;
                    }
                    else {
                        breaks = (Condition_Info)listType1Value[2][0];
                    }
                    if (listType1Value[3].Count == 0) {
                        continues = null;
                    }
                    else {
                        continues = (Condition_Info)listType1Value[3][0];
                    }
                    newCardConcept = new Looping_Info(con, listType1Value[1],breaks,continues);
                    break;
                case "Variable":
                    newCardConcept = new Variable_Info(listType2Value["Type"], listType2Value["Value"]);
                    break;
                case "Comparison":
                    Concept_Info objA;
                    Logic_Info com_sym;
                    Concept_Info objB;
                    if (listType1Value[0].Count == 0) {
                        objA = null;
                    }
                    else {
                        objA = listType1Value[0][0];
                    }
                    if (listType1Value[1].Count == 0) {
                        com_sym = null;
                    }
                    else {
                        com_sym = (Logic_Info)listType1Value[1][0];
                    }
                    if (listType1Value[2].Count == 0) {
                        objB = null;
                    }
                    else {
                        objB = listType1Value[2][0];
                    }
                    newCardConcept = new Comparison_Info(objA, objB, com_sym);
                    break;
            }
            
            current_info = newCardConcept;

            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            Blur_Panel();
            //call the rename panel for concept renaming
            GameObject panel = Instantiate(rename_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
        }
        catch (Exception) {
            GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
            Blur_Panel();
            //call the error panel
            GameObject panel = Instantiate(error_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
            panel.name = panel.name.Replace("(Clone)","").Trim();
            Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            panel.transform.position = new Vector3(center.x,center.y,0);
        }
    }

    //Create the item in main or support concept list
    public void CreatedItem(Concept_Info concept, bool place) {
        GameObject item;
        if (place) {
            item = Instantiate(itemSample, mainConceptList.transform);
        }
        else {
            item = Instantiate(itemSample, supportConceptList.transform);
        }

        Combined_Concept_Drag itemInfo = item.GetComponent<Combined_Concept_Drag>();
        itemInfo.contained_concept_info = concept;
        if (place) {
            itemInfo.isInList = true;
            itemInfo.UpdateMode(true);
        }
        else {
            itemInfo.isInList = false;
            itemInfo.UpdateMode(false);
        }
        itemInfo.UpdateName(concept.nickname);
    }

    //Create the type information item
    public void CreatedItem2(string type, string value) {
        GameObject item = Instantiate(itemSample2, mainConceptList2.transform);
        item.name = item.name.Replace("(Clone)","").Trim();
        item.transform.Find("Input_Type").gameObject.GetComponent<TMP_Text>().SetText(type);
        item.transform.Find("InputField").gameObject.GetComponent<TMP_InputField>().text = value;
    }

    //Transfer the concept to another concept list and update all the information
    public void TransferButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (selected_item != null) {
            if (selected_IsInList) {
                listType1Value[currentPage].RemoveAt(selected_index);
                selected_item.transform.SetParent(supportConceptList.transform);
                selected_item.GetComponent<Combined_Concept_Drag>().isInList = false;
                selected_item.GetComponent<Combined_Concept_Drag>().UpdateMode(false);
                currentChild -= 1;

                for (int i = 0; i < mainConceptList.transform.childCount; i++)
                {
                    GameObject obj = mainConceptList.transform.GetChild(i).gameObject;
                    obj.GetComponent<Combined_Concept_Drag>().totalChild = currentChild;
                }
            }
            else {
                if (childlimit[currentPage] > mainConceptList.transform.childCount || childlimit[currentPage] == -1) {
                    selected_item.transform.SetParent(mainConceptList.transform);
                    listType1Value[currentPage].Add(selected_item.GetComponent<Combined_Concept_Drag>().contained_concept_info);
                    selected_item.GetComponent<Combined_Concept_Drag>().isInList = true;
                    selected_item.GetComponent<Combined_Concept_Drag>().UpdateMode(true);
                    currentChild += 1;

                    for (int i = 0; i < mainConceptList.transform.childCount; i++)
                    {
                        GameObject obj = mainConceptList.transform.GetChild(i).gameObject;
                        obj.GetComponent<Combined_Concept_Drag>().totalChild = currentChild;
                    }
                }
            }
        }
    }

    //Go the the previous page
    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (currentPage > 0) {
            currentPage -= 1;
            PrintAdjustList();
        }
    }

    //Go to the next page
    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (currentPage < pageLimit - 1) {
            currentPage += 1;
            PrintAdjustList();
        }
    }

    //Close the forge panel
    public void CancelButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().UnBlur_Screen();
        Destroy(gameObject);
    }

    //Exchange the position of 2 concept items
    public void ExchangePosition(int index1, int index2){
        Concept_Info temp = listType1Value[currentPage][index1];
        listType1Value[currentPage][index1] = listType1Value[currentPage][index2];
        listType1Value[currentPage][index2] = temp;
    }

    //Update the type information
    public void UpdateType2(string str, string key) {
        listType2Value[key] = str;
    }

    //Empty the list
    private void Empty(int num) {
        if (num == 0) {
            foreach (Transform obj in mainConceptList2.transform) {
                Destroy(obj.gameObject);
            }
        }
        else if (num == 1) {
            foreach (Transform obj in mainConceptList.transform) {
                Destroy(obj.gameObject);
            }
        }
    }

    //Retrieve concept information
    public Concept_Info GetInfo() {
        return current_info;
    }

    //Blurring the whole screen
    public void Blur_Panel() {
        GameObject panel = Instantiate(blur_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
    }

    //Unblurring the screen
    public void UnBlur_Panel() {
        Destroy(GameObject.Find("Blur_Forge_Panel"));
    }
}
