using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Detective_System : MonoBehaviour
{
    public UI_Manager ui_script; //Manager script

    public List<(int, string, string, List<Combined_Card_Info>)> detective_cards; //All detective cards involved in the task
    public GameObject detective_item; //Prefab of item

    //Predefined item position on the monitor
    public List<(double, double)> item_pos = new List<(double, double)> {(-270, 72), (-299,-29), (-256, -162), (-299, 171), (-176, 142), (-200, -65), (-159, 28), (-63, 171), (-29, 57), (-56, -82), (-128, -176), (17, -170), (63, -40), (82, 91), (203, 164),(296,62),(186,33),(167,-90),(266,-52),(203,-176),(296,-154)};
    public List<bool> item_pos_placed;  //List to check whether that position contain item

    public List<Sprite> item_sprites;  //Sprite of the target on the monitor
    public GameObject check_item;  //Prefab of check item in check panel

    public int current_object;  //Current object clicked
    public Combined_Card_Info current_card;  //Current card information clicked

    public GameObject check_panel;  //Panel to show all the concepts
    public GameObject monitor;  //Panel to show the target
    public TMP_Text item_content;  //Description of the target

    float speed = 0.03f;  //Word printing speed
    IEnumerator coroutine;  //Coroutine object for printing action
    bool printing = false;  //Flag to check if coroutine is working

    //Initialize the setting
    void Start()
    {
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
        check_panel = transform.Find("Check_Panel").Find("Scroll View").Find("Viewport").Find("Content").gameObject;
        monitor = transform.Find("Monitor").gameObject;
        detective_cards = ui_script.GetDetectCards();
        item_content = transform.Find("Scroll View").Find("Viewport").Find("Content").GetComponent<TMP_Text>();
        item_pos_placed = new List<bool> {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};
        printing = false;
        UpdateMap();
    }

    //Close the detective panel
    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        ui_script.UnBlur_Screen();
        Destroy(gameObject);
    }

    //Add concept to backpack
    public void AddButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (current_card != null) {
            ui_script.AddToPackPack(current_card);
        }
    }

    //Clear the check panel and create the obejct
    public void CheckButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        Empty();
        CheckObject();
    }

    //Empty the check panel
    void Empty() {
        foreach (Transform obj in check_panel.transform) {
            Destroy(obj.gameObject);
        }
    }

    //Create the check item in check panel
    void CheckObject() {
        for (int i = 0; i < detective_cards[current_object].Item4.Count; i++) {
            GameObject item = Instantiate(check_item, check_panel.transform);
            item.name = item.name.Replace("(Clone)","").Trim();
            item.transform.Find("Text").GetComponent<TMP_Text>().SetText(detective_cards[current_object].Item4[i].nickname);
            item.GetComponent<Check_Item>().item_num = i;
        }
    }

    //Choosing the concept
    public void ChooseCheckObject(int num) {
        current_card = detective_cards[current_object].Item4[num];
    }

    //Create all targets on monitor
    void UpdateMap() {
        for (int i = 0; i < detective_cards.Count; i++) {
            CreateObjects(i);
        }
    }

    //Create a target on monitor
    void CreateObjects(int num) {
        GameObject item = Instantiate(detective_item, monitor.transform);
        item.name = item.name.Replace("(Clone)","").Trim();
        item.GetComponent<Detective_System_Item>().item_num = num;
        item.GetComponent<Image>().sprite = item_sprites[detective_cards[num].Item1];
        //Random placing the target. If try time is exceed, find the first empty postition and create the target
        int try_time = 0;
        while (try_time < 8) {
            int pos = Random.Range(0, item_pos_placed.Count);
            if (item_pos_placed[pos] == false) {
                item.GetComponent<RectTransform>().anchoredPosition = new Vector3(item_pos[pos].Item1.ConvertTo<float>(), item_pos[pos].Item2.ConvertTo<float>(), 0);
                item_pos_placed[pos] = true;
                break;
            }
            else {
                try_time += 1;
            }
        }

        if (try_time >= 8) {
            int pos = item_pos_placed.IndexOf(false);
            item_pos_placed[pos] = true;
            item.GetComponent<RectTransform>().anchoredPosition = new Vector3(item_pos[pos].Item1.ConvertTo<float>(), item_pos[pos].Item2.ConvertTo<float>(), 0);
        }
    }

    //Choosing the target. We should stop the current coroutine if existed and start the printing action
    public void ChooseObject(int num) {
        current_object = num;
        if (printing) {
            StopCoroutine(coroutine);
            
            printing = true;
            item_content.SetText("");
            coroutine = TypeContent(num);
            StartCoroutine(coroutine);        
        }
        else {
            printing = true;
            item_content.SetText("");
            coroutine = TypeContent(num);
            StartCoroutine(coroutine);
        }
    }

    //Coroutine for print action
    IEnumerator TypeContent(int num) {
        foreach (char c in detective_cards[num].Item3) {
            item_content.text += c;
            yield return new WaitForSeconds(speed);
        }
        printing = false;
    }
}
