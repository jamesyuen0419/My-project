using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Page_System : MonoBehaviour
{
    public GameObject menu_panel;  //prefab of menu

    //Direct to task chosen page
    public void StartButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("TaskChosenScene");
    }
    //Direct to leader board page
    public void BoardButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("LeaderBoard");
    }
    //Call the menu panel
    public void MenuButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().Menu_Blur_Screen();
        GameObject panel = Instantiate(menu_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
    }
}
