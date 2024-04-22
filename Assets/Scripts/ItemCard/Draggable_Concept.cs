using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable_Concept : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public String concept_name;
    public Concept_Info concept_info;

    Vector3 fix_vector;
    public GameObject conceptPrefab;

    public GameObject name_panel;

    void OnMouseOver() {
        if (transform.Find("Concept_Name").GetComponent<TMP_Text>().text.Length > 3) {
            if (transform.Find("Concept_Name").GetComponent<TMP_Text>().text.Substring(transform.Find("Concept_Name").GetComponent<TMP_Text>().text.Length - 3, 3) == "...") {
                if (GameObject.Find("Name_Panel") == null) {
                    GameObject panel = Instantiate(name_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
                    panel.name = panel.name.Replace("(Clone)","").Trim();
                    panel.transform.Find("Text").GetComponent<TMP_Text>().SetText(concept_info.nickname);

                    Transform t = panel.transform.Find("Text");
                    TMP_Text t_TMP = t.GetComponent<TMP_Text>();
                    ContentSizeFitter tc = t.GetComponent<ContentSizeFitter>();

                    if (t_TMP.preferredWidth > 200) {
                        tc.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                        tc.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
                        t.GetComponent<RectTransform>().sizeDelta = new Vector2(200, t_TMP.preferredHeight);
                        tc.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                        panel.GetComponent<RectTransform>().sizeDelta = new Vector2(210, t_TMP.preferredHeight);
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
    
    void OnMouseExit() {
        if (GameObject.Find("Name_Panel") != null) {
            Destroy(GameObject.Find("Name_Panel").gameObject);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {   
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject a = Instantiate(conceptPrefab, transform.parent);
        a.name = a.name.Replace("(Clone)","").Trim();
        a.transform.position = transform.position;
        if (GameObject.Find("Forge_Panel") == null) {
            transform.parent.parent.GetComponent<Search_System>().item = a;
        }
        else {
            transform.parent.parent.GetComponent<Search_System_Forge_Panel>().item = a;
        }
        Draggable_Concept drag = a.GetComponent<Draggable_Concept>();
        drag.concept_name = concept_name;
        drag.concept_info = concept_info;

        transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        fix_vector = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.SetAsLastSibling();
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (GameObject.Find("Name_Panel") != null) {
            Destroy(GameObject.Find("Name_Panel").gameObject);
        }
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - fix_vector;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (GameObject.Find("Name_Panel") != null) {
            Destroy(GameObject.Find("Name_Panel").gameObject);
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Destroy(gameObject);
    }
}
