using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Top_Bar : MonoBehaviour
{
    TMP_Text task_name;  //task name container

    public GameObject tutorial_panel;  //prefab of tutorial panel

    //Initialize the setting
    void Start()
    {
        task_name = transform.Find("Task_Name").GetComponent<TMP_Text>();
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().SetTaskTopic();
    }

    //Update task name
    public void SetTaskName(string name) {
        task_name.SetText(name);
    }

    //Redirect to task chosen page
    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        SceneManager.LoadScene("TaskChosenScene");
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
