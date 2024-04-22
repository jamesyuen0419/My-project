using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Panel : MonoBehaviour
{
    public Tutorial_Sprite tutorial_slide;
    List<List<string>> tutorial_description = new List<List<string>> {
        new() {
            "Here we will introduce some key features and how you can finish the tasks!",
            "On the bottom left corner, you can see the dialogue system and you can see the instruction and description about every sub tasks!",
            "On the top left corner, you can see the hint system where you can check all the character personal tasks or some hints.",
            "Click the personal task you are interested. A panel will come out and you can see the detailed information about him/her in that sub task.\nNoticed that sometimes it may not a single task only! It can be multiple sub tasks or just the thinking retrive from the character's mind. Check carefully!",
            "On the bottom right corner, you can see a button set. It consist of three main system.",
            "Fisrt button represents forge system. On top, that is the search system!",
            "You can find different type of concept you need using the drop down menu and the search button.",
            "You can also see the combined concept when you change to the second mode by clicking the right button!",
            "Notice you can deleted the concept to keep your back pack tidy and you can check the concept information by clicking the info button!",
            "If you want to combine the concept, drag the concept or combined concept from the search system to the forge panel below.\n\nLeft arm will hold the main concept and right arm will hold the support concept you wish to add into the main concept.\nThe information of the concepts will appear in the middle once you put the concept on the robot arm.",
            "Second button represents concept search system. You can see different type of concepts and you can click into the concept to learn more about that!",
            "Third button represents the submit system. You can submit the concepts you want by dragging the concept to different characters. There is a panel on the right to check what concept you have handed in.",
            "If you answer is wrong. It will have two situations. First, just the name become red. It means the number of submitted concept is not as expected!",
            "Second situation is that a function cell become red. It means this concept did somethings wrong!"
        },
        new() {
            "Here is the forge panel system for your concept combination!",
            "The panel located on the right contains your support concept to be put inside your main concept.",
            "Noticed that there is a search system on the bottom. You can also drag the concepts you want to put in the main concept to the support panel!",
            "Button on the middle is the transfer button.\nWhen you click a concept on the main panel and click transfer button, you can remove that concept.\nYou can also add concept to the main concept by clicking the concept you want in the support panel.",
            "Some concept may consist of several parts, you can click the left/right button to change the part you want to add or remove concepts.",
            "Once you finish the modification, click the Combine button! Then, you can rename you combined concept! Always rename so that you can remember what you have made!"
        },
        new() {
            "After you finish several tasks, Helper will help you open the detective system which you can check some extra information and get the extra concept which may related to the answer!",
            "There are three type of targets locate on the monitor. Creature, Location and Things!",
            "You can click one of them and you can see the information about this target.If you are interested in this target, you can click the check button to find the extra concepts from it.",
            "If you find the concepts useful, just press the Add button to retrieve it!",
            "Noticed that due to the instability, targets will change their position on the map when you open the detective system!"
        
        },
        new() {
            "There are number of task type existed in this game!",
            "Normal Game Task: User need to follow the game instruction given in the task and make use of the given concepts to build the suitable combined concepts.",
            "Big Task: Instead of looking at the instruction, user need to check all the hints and given resources to figure out what concepts are needed for a big scale task.",
            "Chaos State Task: Not just follow the instruction only! Keep Thinking!\n\nReality is keep changing! Sometimes the instruction may not be true. User need to take care all the given information to find out the answer."
        },
        new() {
            "When you click the LeaderBoard button in the start page, you can see a page that contain your game information! Including the time duration since you first enter the game, number of finished task and the learning progress of different programming concept!"
        }
    };

    List<string> tutorial_topic = new List<string> {"Gameplay", "Concept Combination", "Detective System", "Task Type", "LeaderBoard"};
    GameObject image_shown;

    public GameObject check_panel;
    public TMP_Text item_content;
    public GameObject tutorial_item;

    int max_slide = 10;
    int current_slide = 0;
    int current_topic = 0;

    void Start()
    {
        image_shown = transform.Find("Image").gameObject;
        check_panel = transform.Find("Check_Panel").Find("Scroll View").Find("Viewport").Find("Content").gameObject;
        item_content = transform.Find("Scroll View").Find("Viewport").Find("Content").GetComponent<TMP_Text>();
        current_slide = 0;
        current_topic = 0;
        CreateObject();
    }

    public void CloseButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(0);
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().UnBlur_Screen();
        Destroy(gameObject);
    }

    public void LeftButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_slide > 0) {
            current_slide -= 1;
            UpdateSlide();
        }
    }

    public void RightButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        if (current_slide < max_slide - 1) {
            current_slide += 1;
            UpdateSlide();
        }
    }

    public void CheckButtonEvent() {
        GameObject.FindGameObjectWithTag("UI_Manager").GetComponent<UI_Manager>().PlaySound(3);
        current_slide = 0;
        max_slide = tutorial_description[current_topic].Count;
        UpdateSlide();
    }

    private void UpdateSlide() {
        List<Sprite> slides = null;
        switch (current_topic) {
            case 0:
                slides = tutorial_slide.p1;
                break;
            case 1:
                slides = tutorial_slide.p2;
                break;
            case 2:
                slides = tutorial_slide.p3;
                break;
            case 3:
                slides = tutorial_slide.p4;
                break;
            case 4:
                slides = tutorial_slide.p5;
                break;
        }
        image_shown.GetComponent<Image>().sprite = slides[current_slide];
        item_content.SetText(tutorial_description[current_topic][current_slide]);
    }

    public void ChooseObject(int num) {
        current_topic = num;
    }

    public void CreateObject(){
        for (int i = 0; i < tutorial_topic.Count; i++) {
            GameObject item = Instantiate(tutorial_item, check_panel.transform);
            item.name = item.name.Replace("(Clone)","").Trim();
            item.transform.Find("Text (TMP)").GetComponent<TMP_Text>().SetText(tutorial_topic[i]);
            item.GetComponent<Tutorial_Item>().item_num = i;
        }
    }
}
