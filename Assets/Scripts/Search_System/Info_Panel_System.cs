using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Info_Panel_System : MonoBehaviour
{
    public GameObject region_name;  //object to show current concept part name
    public GameObject mainConceptContainer;  //concept container type 1 (block type)
    public GameObject mainConceptList;  //concept container content type 1
    public GameObject itemSample;  //type 1 component
    public GameObject mainConcept2Container;  //concept container type 2 (word type)
    public GameObject mainConceptList2;  //concept container content type 2
    public GameObject itemSample2;  //type 2 component

    public int current_name;  //current region number
    public string action_concept_name;  //action card concept name
    public Concept_Info concept_info;  //action card concept information

    public List<string> Region_names;  //region name list
    public Dictionary<string, string> listType2Value;  //container type 2 list
    public List<List<Concept_Info>> listType1Value;  //container type 1 list
    public List<int> mode;  //region mode list

    //Initialize the setting
    void Start()
    {
        region_name = transform.Find("Region_Name").gameObject;
        mainConceptContainer = GameObject.FindGameObjectWithTag("concept_adjust_list");
        mainConceptList = GameObject.FindGameObjectWithTag("concept_adjust_list").transform.Find("Viewport").Find("Content").gameObject;
        mainConcept2Container = GameObject.FindGameObjectWithTag("concept_adjust_list_2");
        mainConceptList2 = GameObject.FindGameObjectWithTag("concept_adjust_list_2").transform.Find("Viewport").Find("Content").gameObject;
        current_name = 0;
        listType2Value = new Dictionary<string, string>();
        listType1Value = new List<List<Concept_Info>>();
        UpdateAdjustList();
    }

    //Update the information
    public void UpdateContent(string name, Concept_Info concept_info) {
        action_concept_name = name;
        this.concept_info = concept_info;
    }

    //Update the setting and information of the panel according to concept type
    public void UpdateAdjustList() {
        switch (action_concept_name) {
            case "Condition":
                Region_names = new List<string> {"Condition"};
                mode = new List<int> {1};
                if (((Condition_Info) concept_info).condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((Condition_Info) concept_info).condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Container":
                Region_names = new List<string> {"Contained_Item"};
                mode = new List<int> {1};
                if (((Container_Info) concept_info).contained_items != null) {
                    listType1Value.Add(((Container_Info) concept_info).contained_items);
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Range":
                Region_names = new List<string> {"Range"};
                mode = new List<int> {0};
                listType2Value = new Dictionary<String, String>
                {
                    { "Start", ((Range_Info)concept_info).start.ToString()},
                    { "End", ((Range_Info)concept_info).end.ToString()},
                    { "Interval", ((Range_Info)concept_info).interval.ToString()}
                };
                listType1Value = null;
                break;
            case "Range_Var":
                Region_names = new List<string> {"Start", "End", "Interval"};
                mode = new List<int> {1,1,1};
                if (((RangeVar_Info) concept_info).start != null) {
                    listType1Value.Add(new List<Concept_Info> {((RangeVar_Info) concept_info).start});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((RangeVar_Info) concept_info).end != null) {
                    listType1Value.Add(new List<Concept_Info> {((RangeVar_Info) concept_info).end});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((RangeVar_Info) concept_info).interval != null) {
                    listType1Value.Add(new List<Concept_Info> {((RangeVar_Info) concept_info).interval});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "IfStatement":
                Region_names = new List<string> {"Condition", "Result"};
                mode = new List<int> {1,1};
                if (((If_Statement_Info) concept_info).condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((If_Statement_Info) concept_info).condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((If_Statement_Info) concept_info).results != null) {
                    listType1Value.Add(((If_Statement_Info) concept_info).results);
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Looping":
                mode = new List<int> {1,1,1,1};
                Region_names = new List<string> {"Condition", "Action", "Break Condition", "Continue Condition"};
                if (((Looping_Info) concept_info).condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((Looping_Info) concept_info).condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Looping_Info) concept_info).actions != null) {
                    listType1Value.Add(((Looping_Info) concept_info).actions);
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Looping_Info) concept_info).break_condition != null) {
                   listType1Value.Add(new List<Concept_Info> {((Looping_Info) concept_info).break_condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Looping_Info) concept_info).continue_condition != null) {
                    listType1Value.Add(new List<Concept_Info> {((Looping_Info) concept_info).continue_condition});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Variable":
                mode = new List<int> {0};
                Region_names = new List<string> {"Info"};
                listType2Value = new Dictionary<String, String> {
                    {"Type", ((Variable_Info) concept_info).variable_type},
                    {"Name", ((Variable_Info) concept_info).variable_name}
                };
                listType1Value = null;
                break;
            case "Comparison":
                Region_names = new List<string> {"Object 1", "Operator", "Object 2"};
                mode = new List<int> {1,1,1};
                if (((Comparison_Info) concept_info).objA != null) {
                    listType1Value.Add(new List<Concept_Info> {((Comparison_Info) concept_info).objA});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Comparison_Info) concept_info).sym != null) {
                    listType1Value.Add(new List<Concept_Info> {((Comparison_Info) concept_info).sym});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                if (((Comparison_Info) concept_info).objB != null) {
                    listType1Value.Add(new List<Concept_Info> {((Comparison_Info) concept_info).objB});
                }
                else {
                    listType1Value.Add(new List<Concept_Info>());
                }
                break;
            case "Action":
                Region_names = new List<string> {"Action Name"};
                mode = new List<int> {0};
                listType2Value = new Dictionary<String, String>
                {
                    { "Action", ((Action_Info)concept_info).action},
                };
                listType1Value = null;
                break;
            case "Object":
                Region_names = new List<string> {"Object Name"};
                mode = new List<int> {0};
                listType2Value = new Dictionary<String, String>
                {
                    { "Object", ((Object_Info)concept_info).object_name},
                };
                listType1Value = null;
                break;
        }

        PrintAdjustList();
    }

    //Print the concept list
    public void PrintAdjustList() {
        region_name.GetComponent<TMP_Text>().SetText(Region_names[current_name]);
        if (mode[current_name] == 0) {
            mainConceptContainer.SetActive(false);
            mainConcept2Container.SetActive(true);
            Empty(0);
            foreach(KeyValuePair<String, String> pair in listType2Value){
                        CreatedItem2(pair.Key, pair.Value);
            }
        }
        else if (mode[current_name] == 1) {
            mainConceptContainer.SetActive(true);
            mainConcept2Container.SetActive(false);
            Empty(1);
            if (listType1Value[current_name].Count > 0) {
                foreach(Concept_Info concept in listType1Value[current_name]) {
                    CreatedItem(concept);
                }
            } 
        }
    }

    //Create the item in concept list
    public void CreatedItem(Concept_Info concept) {
        GameObject item = Instantiate(itemSample, mainConceptList.transform);
        Info_Panel_Item itemInfo = item.GetComponent<Info_Panel_Item>();
        itemInfo.UpdateName(concept.nickname);
    }

    //Create the type information item
    public void CreatedItem2(String type, String value) {
        GameObject item = Instantiate(itemSample2, mainConceptList2.transform);
        item.name = item.name.Replace("(Clone)","").Trim();
        item.transform.Find("Input_Type").gameObject.GetComponent<TMP_Text>().SetText(type);
        item.transform.Find("InputField").gameObject.GetComponent<TMP_InputField>().text = value;
        item.transform.Find("InputField").gameObject.GetComponent<TMP_InputField>().interactable = false;
    }

    //Empty concept component display
    private void Empty(int num) {
        if (num == 0) {
            int childNumber = mainConceptList2.transform.childCount;
            for (int i = 0; i < childNumber; i++) {
                Destroy(mainConceptList2.transform.GetChild(0).gameObject);
            }
        }
        else if (num == 1) {
            int childNumber = mainConceptList.transform.childCount;
            for (int i = 0; i < childNumber; i++) {
                Destroy(mainConceptList.transform.GetChild(0).gameObject);
            }
        }
    }

    //Control to the previous region
    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_name > 0) {
            current_name -= 1;
            PrintAdjustList();
        }
    }

    //Control to the next region
    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_name < Region_names.Count - 1) {
            current_name += 1;
            PrintAdjustList();
        }
    }

    //Close the info panel
    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().UnBlur_Screen();
        Destroy(gameObject);
    }

}
