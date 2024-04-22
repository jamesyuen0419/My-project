using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detective_System_Item : MonoBehaviour
{
    public int item_num;

    //Notify the item number clicked
    public void ClickEvent() {
        GameObject.Find("Detective_Panel").GetComponent<Detective_System>().ChooseObject(item_num);
    }
}
