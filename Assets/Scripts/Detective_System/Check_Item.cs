using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Item : MonoBehaviour
{
    public int item_num;

    //Notify the item number clicked
    public void ClickEvent() {
        GameObject.Find("Detective_Panel").GetComponent<Detective_System>().ChooseCheckObject(item_num);
    }
}
