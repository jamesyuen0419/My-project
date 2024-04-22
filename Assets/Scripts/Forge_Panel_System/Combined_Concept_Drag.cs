using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

//This coding is learnt from https://github.com/dipen-apptrait/Vertical-drag-drop-listview-unity/blob/master/DragController.cs
//which can drage item is the container to adjust its position

public class Combined_Concept_Drag : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public RectTransform currentTransform;  //transform of current object
    private GameObject mainContent;  //Parent container object
    private Vector3 currentPosition;  //position of current object 
    public int totalChild;  //number of child object in parent object
    public bool isInList;  //this object is in the main concept or not
    public GameObject panel_sys;  //forge system
    public Concept_Info contained_concept_info;  //concept info of object
    public int index;  //object child index
    public bool edit_mode = false;  //if this object can be moved
    public string concept_name;  //name of the concept

    //Initialize the setting
    void Start() {
        currentTransform = GetComponent<RectTransform>();
        panel_sys = transform.parent.parent.parent.parent.gameObject;
    }

    //Update the information of object
    public void UpdateMode(bool state) {
        edit_mode = state;
        currentTransform = GetComponent<RectTransform>();
        panel_sys = transform.parent.parent.parent.parent.gameObject;

    }

    //Update concept name
    public void UpdateName(string name) {
        concept_name = name;
        gameObject.transform.Find("Text").GetComponent<TMP_Text>().SetText(name);

    }

    //Update the selected object. If concept can be edited, retrieve the infromation for later dragging
    public void OnPointerDown(PointerEventData eventData)
    {   
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (edit_mode) {
            if (isInList) {
                mainContent = currentTransform.parent.gameObject;
                currentPosition = currentTransform.position;
                totalChild = mainContent.transform.childCount;
            }

            index = currentTransform.GetSiblingIndex();
        }
        
        panel_sys.GetComponent<Forge_Panel_System>().Selected(gameObject, isInList, index);
    }

    //Dragging process of the object and exchange the position with other object in the main concept list
    public void OnDrag(PointerEventData eventData)
    {
        if (edit_mode) {
            if (isInList) {
                currentTransform.position = new Vector3(currentTransform.position.x, Camera.main.ScreenToWorldPoint(eventData.position).y, currentTransform.position.z);
            
                for (int i = 0; i < totalChild; i++)
                {
                    if (i != currentTransform.GetSiblingIndex())
                    {
                        Transform otherTransform = mainContent.transform.GetChild(i);
                        int distance = (int) Vector3.Distance(currentTransform.position, otherTransform.position);
                        if (distance <= 1)
                        {
                            panel_sys.GetComponent<Forge_Panel_System>().ExchangePosition(index, i);
                            Vector3 otherTransformOldPosition = otherTransform.position;
                            otherTransform.position = new Vector3(otherTransform.position.x, currentPosition.y, otherTransform.position.z);
                            currentTransform.position = new Vector3(currentTransform.position.x, otherTransformOldPosition.y, currentTransform.position.z);
                            currentTransform.SetSiblingIndex(otherTransform.GetSiblingIndex());
                            currentPosition = currentTransform.position;
                        }
                    }
                }
            }       
        }
    }

    //Update the position to drop
    public void OnPointerUp(PointerEventData eventData)
    {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (edit_mode) {
            if (isInList) {
                currentTransform.position = currentPosition;
            }
        }
    }
}
