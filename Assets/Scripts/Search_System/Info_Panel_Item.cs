using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info_Panel_Item : MonoBehaviour
{
    public void UpdateName(string name) {
        gameObject.transform.Find("Text").GetComponent<TMP_Text>().SetText(name);

    }
}
