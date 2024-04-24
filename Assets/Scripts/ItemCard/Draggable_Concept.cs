using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable_Concept : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public string concept_name;  //concept name
    public Concept_Info concept_info;  //concept information

    Vector3 fix_vector;  //vector difference for mouse coordinate system and transform position
    public GameObject conceptPrefab;  //prefab of concept block

    public GameObject name_panel;  //prefab for name panel

    //Handle the case for name tag generation when the concept name length is out of range
    void OnMouseOver() {
        if (transform.Find("Concept_Name").GetComponent<TMP_Text>().text.Length > 3) {
            if (transform.Find("Concept_Name").GetComponent<TMP_Text>().text.Substring(transform.Find("Concept_Name").GetComponent<TMP_Text>().text.Length - 3, 3) == "...") {
                if (GameObject.Find("Name_Panel") == null) {
                    //generate name tag
                    GameObject panel = Instantiate(name_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
                    panel.name = panel.name.Replace("(Clone)","").Trim();
                    panel.transform.Find("Text").GetComponent<TMP_Text>().SetText(concept_info.nickname);

                    Transform t = panel.transform.Find("Text");
                    TMP_Text t_TMP = t.GetComponent<TMP_Text>();
                    ContentSizeFitter tc = t.GetComponent<ContentSizeFitter>();

                    //when name tag too long, resize by using the content size fitter preferred size property
                    if (t_TMP.preferredWidth > 200) {
                        tc.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                        tc.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
                        t.GetComponent<RectTransform>().sizeDelta = new Vector2(200, t_TMP.preferredHeight);
                        tc.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                        //resize name tag background height
                        panel.GetComponent<RectTransform>().sizeDelta = new Vector2(210, t_TMP.preferredHeight);
                        //adjust name tag position to bottom left side
                        panel.transform.position = new Vector3(transform.position.x - panel.GetComponent<RectTransform>().sizeDelta.x * 10 / 200, transform.position.y - panel.GetComponent<RectTransform>().sizeDelta.y * 4 / 36 ,transform.position.z);
                    }
                    else {
                        panel.GetComponent<RectTransform>().sizeDelta = new Vector2(t_TMP.preferredWidth + t_TMP.preferredWidth * 0.1f, t_TMP.preferredHeight);
                        panel.transform.position = new Vector3(transform.position.x - panel.GetComponent<RectTransform>().sizeDelta.x * 10 / 200, transform.position.y - panel.GetComponent<RectTransform>().sizeDelta.y * 4 / 36 ,transform.position.z);
                    }
                }
            }
        }
    }
    
    //End the hover event by deleting the name tag
    void OnMouseExit() {
        if (GameObject.Find("Name_Panel") != null) {
            Destroy(GameObject.Find("Name_Panel").gameObject);
        }
    }

    //Grab process
    public void OnPointerDown(PointerEventData eventData)
    {   
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        //create concept block clone
        GameObject a = Instantiate(conceptPrefab, transform.parent);
        a.name = a.name.Replace("(Clone)","").Trim();
        a.transform.position = transform.position;
        //replace original concept block
        if (GameObject.Find("Forge_Panel") == null) {
            transform.parent.parent.GetComponent<Search_System>().item = a;
        }
        else {
            transform.parent.parent.GetComponent<Search_System_Forge_Panel>().item = a;
        }
        //copy concept information
        Draggable_Concept drag = a.GetComponent<Draggable_Concept>();
        drag.concept_name = concept_name;
        drag.concept_info = concept_info;
        //set the clone parent and calculate position difference
        transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        fix_vector = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //change hierarchy and disable blocksRaycasts so no collision during dragging to let drop event occured successfully
        transform.SetAsLastSibling();
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    //Continue drag process
    public void OnDrag(PointerEventData eventData)
    {
        //force name tag follow dragging process
        if (GameObject.Find("Name_Panel") != null) {
            Destroy(GameObject.Find("Name_Panel").gameObject);
        }
        //compute true position
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - fix_vector;
    }

    //Drop process
    public void OnPointerUp(PointerEventData eventData)
    {
        //remove name tag
        if (GameObject.Find("Name_Panel") != null) {
            Destroy(GameObject.Find("Name_Panel").gameObject);
        }
        //enable collision for drop event detection
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Destroy(gameObject);
    }
}
