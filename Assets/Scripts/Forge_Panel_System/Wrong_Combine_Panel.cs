using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrong_Combine_Panel : MonoBehaviour
{
    //Close the wrong combine panel
    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.Find("Forge_Panel").GetComponent<Forge_Panel_System>().UnBlur_Panel();
        Destroy(gameObject);
    }
}
