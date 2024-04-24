using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Top_Bar_TaskChosen : MonoBehaviour
{
    public GameObject tutorial_panel;  //prefab of tutorial panel

    //Redirect to start page
    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("StartScene");
    }

    //Call the tutorial panel
    public void TutorialButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(4);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().Blur_Screen();
        GameObject panel = Instantiate(tutorial_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
    }
}
