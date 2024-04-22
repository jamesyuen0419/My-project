using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_System : MonoBehaviour
{
    public GameObject forge_page;
    public GameObject search_page;
    public GameObject submission_page;
    public GameObject current_page;

    void Start()
    {
        //when user enter the gmae, forge page should be automatically shown.
        ForgeButtonEvent();
    }

    //This is the forge button click event to called the forge page
    public void ForgeButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (current_page != null) {
            GameObject page = Instantiate(forge_page, GameObject.FindGameObjectWithTag("Canvas").transform);
            page.name = page.name.Replace("(Clone)","").Trim();
            Destroy(current_page);
            current_page = page;
        }
        else {
            GameObject page = Instantiate(forge_page, GameObject.FindGameObjectWithTag("Canvas").transform);
            page.name = page.name.Replace("(Clone)","").Trim();
            current_page = page;
        }
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().SetCurrentActivePage(0);
    }

    //This is the search button click event to called the concept search page
    public void SearchButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (current_page != null) {
            GameObject page = Instantiate(search_page, GameObject.FindGameObjectWithTag("Canvas").transform);
            page.name = page.name.Replace("(Clone)","").Trim();
            Destroy(current_page);
            current_page = page;
        }
        else {
            GameObject page = Instantiate(search_page, GameObject.FindGameObjectWithTag("Canvas").transform);
            page.name = page.name.Replace("(Clone)","").Trim();
            current_page = page;
        }
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().SetCurrentActivePage(1);
    }

    //This is the submit button click event to called the submit page
    public void SubmissionButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        if (current_page != null) {
            GameObject page = Instantiate(submission_page, GameObject.FindGameObjectWithTag("Canvas").transform);
            page.name = page.name.Replace("(Clone)","").Trim();
            Destroy(current_page);
            current_page = page;
        }
        else {
            GameObject page = Instantiate(submission_page, GameObject.FindGameObjectWithTag("Canvas").transform);
            page.name = page.name.Replace("(Clone)","").Trim();
            current_page = page;
        }
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().SetCurrentActivePage(2);
    }
    
}
