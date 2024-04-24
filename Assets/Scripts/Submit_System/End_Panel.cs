using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Panel : MonoBehaviour
{
    //Finish the game and direct back to task chosen page
    public void BackButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().UnBlur_Screen();
        SceneManager.LoadScene("TaskChosenScene");
    }
}
