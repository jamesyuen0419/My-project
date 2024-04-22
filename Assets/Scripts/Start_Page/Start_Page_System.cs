using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Page_System : MonoBehaviour
{
    public GameObject menu_panel;

    public void StartButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("TaskChosenScene");
    }
    public void BoardButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("LeaderBoard");
    }
    public void MenuButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().Menu_Blur_Screen();
        GameObject panel = Instantiate(menu_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
    }
}
