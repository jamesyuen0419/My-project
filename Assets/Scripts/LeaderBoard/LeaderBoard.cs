using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using TMPro;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    public UI_Manager ui_script;  //manager script

    public List<Sprite> spritelist;  //learning state list

    public DateTime first_login_time;  //login date time for enter the task 0
    public DateTime time_now;  //current date time
    public int task_completed;  //number of task completed

    public int current_page;  //current page for learning progress
    public int max_page = 9;  //number of concept


    //Initialize the setting
    void Start()
    {
        ui_script = GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>();

        //situation when user not yet start any task
        if (ui_script.GetPlayerFirstTime() == null) {
            transform.Find("TimePanel").Find("Time_Message").GetComponent<TMP_Text>().SetText("Let try this game now!");
        }
        else {
            //calculate hours difference
            first_login_time = DateTime.Parse(ui_script.GetPlayerFirstTime());
            time_now = DateTime.Now;
            string hours = Mathf.RoundToInt((time_now - first_login_time).TotalHours.ConvertTo<float>()).ToString();
            transform.Find("TimePanel").Find("Time_Message").GetComponent<TMP_Text>().SetText("It is already " + hours + " hours after you enter the first task!");
        }

        task_completed = ui_script.GetTaskCompleted();
        string task_completed_string = task_completed.ToString();
        string task_total = ui_script.GetTaskTotal().ToString();
        transform.Find("LevelPanel").Find("Level_Message").GetComponent<TMP_Text>().SetText("You have completed " + task_completed_string + " / " + task_total + " tasks. Keep Going!");

        current_page = 0;
        max_page = 9;

        UpdateProgress();
    }

    //Control learning progress to the previous page
    public void LeftButtonEvent() {
        ui_script.PlaySound(0);
        if (current_page > 0) {
            current_page -= 1;
            UpdateProgress();
        }
    }

    //Control learning progress to the next page
    public void RightButtonEvent() {
        ui_script.PlaySound(0);
        if (current_page < max_page - 1) {
            current_page += 1;
            UpdateProgress();
        }
    }

    //Check the learning progress for certain concept and modify the provided information
    public void UpdateProgress() {
        string concept = "";
        int progress = 0;
        string level = "";
        string next_level = "";

        //set the learning progress for different concept
        switch (current_page) {
            case 0:
                concept = "Looping";
                (progress, level, next_level) = FindConcept(4,7,18);
                break;
            case 1:
                concept = "Condition";
                (progress, level, next_level) = FindConcept(3,8,13);
                break;
            case 2:
                concept = "Logic";
                (progress, level, next_level) = FindConcept(4,8,20);
                break;
            case 3:
                concept = "Comparison";
                (progress, level, next_level) = FindConcept(4,10,20);
                break;
            case 4:
                concept = "IfElse";
                (progress, level, next_level) = FindConcept(6,12,13);
                break;
            case 5:
                concept = "Variable";
                (progress, level, next_level) = FindConcept(2,6,9);
                break;
            case 6:
                concept = "Container";
                (progress, level, next_level) = FindConcept(6,11,20);
                break;
            case 7:
                concept = "Action";
                (progress, level, next_level) = FindConcept(4,9,11);
                break;
            case 8:
                concept = "Object";
                (progress, level, next_level) = FindConcept(4,9,11);
                break;
            case 9:
                concept = "Range";
                (progress, level, next_level) = FindConcept(4,8,17);
                break;
        }
        transform.Find("ConceptPanel").Find("ShowPanel").Find("Image").GetComponent<Image>().sprite = spritelist[progress];
        transform.Find("ConceptPanel").Find("DescriptionPanel").Find("LinePanel").Find("ProgressPanel1").Find("Text").GetComponent<TMP_Text>().SetText("Progress of " + concept + " Concept: " + level);
        
        //set up provided information
        string progress_text = "";
        string next_text = "You can reach the next level after finish task " + next_level;
        switch (level) {
            case "Kid":
                progress_text = "You start to explore the meaning of this concept!";
                break;
            case "Primary Student":
                progress_text = "You have the basic knowledge of this concept!";
                break;
            case "Secondary Student":
                progress_text = "Good! Try to practice more in the tasks!";
                break;
            case "Master":
                progress_text = "You can apply this concept in the tasks very well!";
                next_text = "You already reached the highest level! Good Job!";
                break;
        }
        transform.Find("ConceptPanel").Find("DescriptionPanel").Find("LinePanel").Find("ProgressPanel2").Find("Text").GetComponent<TMP_Text>().SetText(progress_text);
        transform.Find("ConceptPanel").Find("DescriptionPanel").Find("LinePanel").Find("ProgressPanel3").Find("Text").GetComponent<TMP_Text>().SetText(next_text);
    }

    //Learning progress information set up function
    (int, string, string) FindConcept(int l1, int l2, int l3) {
        if (task_completed < l1) {
            return (0, "Kid", (l1 - task_completed).ToString());
        }
        else if (task_completed < l2) {
            return (1, "Primary Student", (l2 - task_completed).ToString());
        }
        else if (task_completed < l3) {
            return (2, "Secondary Student", (l3 - task_completed).ToString());
        }
        else {
            return (3, "Master", "");
        }
    }
}
