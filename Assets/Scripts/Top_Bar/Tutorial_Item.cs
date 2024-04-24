using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Item : MonoBehaviour
{
    public int item_num;  //object number

    //Update click event of this object
    public void ClickEvent() {
        GameObject.Find("Tutorial_Panel").GetComponent<Tutorial_Panel>().ChooseObject(item_num);
    }
}
