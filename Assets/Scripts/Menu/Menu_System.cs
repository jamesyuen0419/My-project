using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_System : MonoBehaviour
{
    public UI_Manager ui_script;  //manager script

    public Slider slider;  //volume silder object

    public GameObject restart_button;
    public GameObject back_button;

    //Initialize the setting
    void Start()
    {
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();
        slider = transform.Find("Volume_Container").Find("Slider").GetComponent<Slider>();
        slider.value = ui_script.GetAudioVol();

        //avoid unexpected click event
        if (SceneManager.GetActiveScene().name != "SampleScene") {
            restart_button.GetComponent<Button>().interactable = false;
            back_button.GetComponent<Button>().interactable = false;
        }
    }

    //Initialize the game
    public void RestartButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        ui_script.InitialTask();
    }

    //Terminate the game
    public void QuitButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        Application.Quit();
    }

    //Close the menu
    public void BackButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        ui_script.Menu_UnBlur_Screen();
        Destroy(gameObject);
    }

    //Retrieve slider data
    public void SliderChanged(Slider slider) {
        ui_script.SetAudioVol(slider.value);
    }
}
