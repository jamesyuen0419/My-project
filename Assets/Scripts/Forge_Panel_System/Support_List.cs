using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Support_List : MonoBehaviour, IDropHandler
{
    Concept_Info concept_info;  //support concept information

    //When concept drop in the support concept list, create the item to the list and update the information
    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag.transform.GetComponent<Draggable_Concept>() != null) {
            Draggable_Concept con = eventData.pointerDrag.transform.GetComponent<Draggable_Concept>();
            concept_info = con.concept_info;
        }
        else {
            Combined_Action_Card con = eventData.pointerDrag.transform.GetComponent<Combined_Action_Card>();
            concept_info = con.concept_info;
        }
        
        transform.parent.GetComponent<Forge_Panel_System>().CreatedItem(concept_info, false);
    }
}
