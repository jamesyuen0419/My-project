using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UI_Manager : MonoBehaviour
{
    public DataBase database_script;
    public GameObject menu;
    public GameObject blur_panel;
    public GameObject menu_blur_panel;

    private List<Combined_Card_Info> backpack_cards;
    public List<Sprite> object_sprite_list;
    public List<List<Concept_Info>> submitted_concept_info;

    public int current_active_page;
    public TaskObjectSprite current_task_object_sprites;
    public TaskObjectName current_task_object_names;
    public ActionAndObject act_obj;

    public Detective_Item detective_cards;

    public SearchPageSpriteList concept_search_sprites; 
    public Answer answer; 
    public TaskDialogue dialogue;
    public Hint hints;

    public int task_number = 0;
    public int subtask_num = 0;
    public int current_subtask = 0;

    public float audioVol;
    public List<AudioClip> sounds;
    public int task_completed;
    public int task_total = 20;

    void Awake() {
        int num = GameObject.FindGameObjectsWithTag("UI_Manager").Length;
        if (num > 1) {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start() {
        (task_completed, audioVol) = database_script.GetPlayerSetting();
        backpack_cards = new List<Combined_Card_Info>();
        current_task_object_names = new TaskObjectName();
        act_obj = new ActionAndObject();
        submitted_concept_info = new List<List<Concept_Info>>();
        hints = new Hint();


        object_sprite_list = GetObjectSprites();
        for (int i = 0; i < object_sprite_list.Count; i++) {
            submitted_concept_info.Add(new List<Concept_Info>());
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameObject.Find("Menu") == null) {
                Menu_Blur_Screen();
                
                GameObject panel = Instantiate(menu, GameObject.FindGameObjectWithTag("Canvas").transform);
                panel.name = panel.name.Replace("(Clone)","").Trim();
                Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                panel.transform.position = new Vector3(center.x,center.y,0);
                
            }
            else {
                Destroy(GameObject.Find("Menu"));
                Menu_UnBlur_Screen();
            }
        }
    }

    void OnApplicationQuit()
    {
        database_script.UpdatePlayerSetting(task_completed, audioVol);
    }

    public List<String> GetConceptNames() {
        return database_script.GetConceptNames();
    }

    public (String, String) GetConceptInfo(int num, int id) {

        Dictionary<string, string> result = database_script.GetConceptInfo(num, id);
        String name = result["name"];
        String description = result["description"];
        return (name, description);
    }

    public List<String> GetInnerConceptNames(int num) {
        return database_script.GetConceptInnerNames(num);
    }
    
    public List<String> SearchButtonDatabase(int num) 
    {
        return database_script.GetSearchConceptList(num);
    }

    public List<Combined_Card_Info> GetCards() 
    {
        return backpack_cards;
    }

    public List<Sprite> GetObjectSprites() 
    {
        switch (task_number) 
        {
            case 0:
                return current_task_object_sprites.Task1;
            case 1:
                return current_task_object_sprites.Task2;
            case 2:
                return current_task_object_sprites.Task3;
            case 3:
                return current_task_object_sprites.Task4;
            case 4:
                return current_task_object_sprites.Task5;
            case 5:
                return current_task_object_sprites.Task6;
            case 6:
                return current_task_object_sprites.Task7;
            case 7:
                return current_task_object_sprites.Task8;
            case 8:
                return current_task_object_sprites.Task9;
            case 9:
                return current_task_object_sprites.Task10;
            case 10:
                return current_task_object_sprites.Task11;
            case 11:
                return current_task_object_sprites.Task12;
            case 12:
                return current_task_object_sprites.Task13;
            case 13:
                return current_task_object_sprites.Task14;
            case 14:
                return current_task_object_sprites.Task15;
            case 15:
                return current_task_object_sprites.Task16;
            case 16:
                return current_task_object_sprites.Task17;
            case 17:
                return current_task_object_sprites.Task18;
            case 18:
                return current_task_object_sprites.Task19;
            case 19:
                return current_task_object_sprites.Task20;
            default:
                return null;
        }
    }

    public List<List<(int, string)>> GetObjectNames() 
    {
        if (current_task_object_names == null) {
            current_task_object_names = new TaskObjectName();
        }

        switch (task_number) 
        {
            case 0:
                return current_task_object_names.Task1;
            case 1:
                return current_task_object_names.Task2;
            case 2:
                return current_task_object_names.Task3;
            case 3:
                return current_task_object_names.Task4;
            case 4:
                return current_task_object_names.Task5;
            case 5:
                return current_task_object_names.Task6;
            case 6:
                return current_task_object_names.Task7;
            case 7:
                return current_task_object_names.Task8;
            case 8:
                return current_task_object_names.Task9;
            case 9:
                return current_task_object_names.Task10;
            case 10:
                return current_task_object_names.Task11;
            case 11:
                return current_task_object_names.Task12;
            case 12:
                return current_task_object_names.Task13;
            case 13:
                return current_task_object_names.Task14;
            case 14:
                return current_task_object_names.Task15;
            case 15:
                return current_task_object_names.Task16;
            case 16:
                return current_task_object_names.Task17;
            case 17:
                return current_task_object_names.Task18;
            case 18:
                return current_task_object_names.Task19;
            case 19:
                return current_task_object_names.Task20;
            default:
                return null;
        }
    }

    public List<Sprite> GetConceptSprites() 
    {
        return concept_search_sprites.search_page_sprite_list;
    }

    public List<List<List<Concept_Info>>> GetAnswer() 
    {
        List<List<List<Concept_Info>>> ans;
        switch (task_number) 
        {
            case 0:
                ans = answer.Tutorial1();
                subtask_num = ans.Count;
                return ans;
            case 1:
                ans = answer.Tutorial2();
                subtask_num = ans.Count;
                return ans;
            case 2:
                ans = answer.Tutorial3();
                subtask_num = ans.Count;
                return ans;
            case 3:
                ans = answer.Tutorial4();
                subtask_num = ans.Count;
                return ans;
            case 4:
                ans = answer.Tutorial5();
                subtask_num = ans.Count;
                return ans;
            case 5:
                ans = answer.Registration_Form();
                subtask_num = ans.Count;
                return ans;
            case 6:
                ans = answer.GoToSchool();
                subtask_num = ans.Count;
                return ans;
            case 7:
                ans = answer.Science_Lesson();
                subtask_num = ans.Count;
                return ans;
            case 8:
                ans = answer.Tidy_Up();
                subtask_num = ans.Count;
                return ans;
            case 9:
                ans = answer.Shopping();
                subtask_num = ans.Count;
                return ans;
            case 10:
                ans = answer.Detective_Tutorial();
                subtask_num = ans.Count;
                return ans;
            case 11:
                ans = answer.Cooking_Lesson();
                subtask_num = ans.Count;
                return ans;
            case 12:
                ans = answer.Sport_Lesson();
                subtask_num = ans.Count;
                return ans;
            case 13:
                ans = answer.BigTask_Tutorial();
                subtask_num = ans.Count;
                return ans;
            case 14:
                ans = answer.Treasure_Hunter();
                subtask_num = ans.Count;
                return ans;
            case 15:
                ans = answer.Chaos();
                subtask_num = ans.Count;
                return ans;
            case 16:
                ans = answer.WorkShop();
                subtask_num = ans.Count;
                return ans;
            case 17:
                ans = answer.RangeVar_Tutorial();
                subtask_num = ans.Count;
                return ans;
            case 18:
                ans = answer.Librarian();
                subtask_num = ans.Count;
                return ans;
            case 19:
                ans = answer.Camping();
                subtask_num = ans.Count;
                return ans;
            default:
                return null;
        }
    }

    public (List<Action_Info>, List<Object_Info>) GetActionAndObject() {
        if (act_obj == null) {
            act_obj = new ActionAndObject();
        }

        switch (task_number)
        {
            case 0:
                return act_obj.Tutorial1();
            case 1:
                return act_obj.Tutorial2();
            case 2:
                return act_obj.Tutorial3();
            case 3:
                return act_obj.Tutorial4();
            case 4:
                return act_obj.Tutorial5();
            case 5:
                return act_obj.Registration_Form();
            case 6:
                return act_obj.GoToSchool();
            case 7:
                return act_obj.Science_Lesson();
            case 8:
                return act_obj.Tidy_Up();
            case 9:
                return act_obj.Shopping();
            case 10:
                return act_obj.Detective_Tutorial();
            case 11:
                return act_obj.Cooking_Lesson();
            case 12:
                return act_obj.Sport_Lesson();
            case 13:
                return act_obj.BigTask_Tutorial();
            case 14:
                return act_obj.Treasure_Hunter();
            case 15:
                return act_obj.Chaos();
            case 16:
                return act_obj.WorkShop();
            case 17:
                return act_obj.RangeVar_Tutorial();
            case 18:
                return act_obj.Librarian();
            case 19:
                return act_obj.Camping();
            default:
                return (null, null);
        }
    }

    public List<String> GetDialogue(){
        if (dialogue == null) {
            dialogue = new TaskDialogue();
        }

        switch (task_number) {
            case 0:
                return dialogue.Tutorial1();
            case 1:
                return dialogue.Tutorial2();
            case 2:
                return dialogue.Tutorial3();
            case 3:
                return dialogue.Tutorial4();
            case 4:
                return dialogue.Tutorial5();
            case 5:
                return dialogue.Registration_Form();
            case 6:
                return dialogue.GoToSchool();
            case 7:
                return dialogue.Science_Lesson();
            case 8:
                return dialogue.Tidy_Up();
            case 9:
                return dialogue.Shopping();
            case 10:
                return dialogue.Detective_Tutorial();
            case 11:
                return dialogue.Cooking_Lesson();
            case 12:
                return dialogue.Sport_Lesson();
            case 13:
                return dialogue.BigTask_Tutorial();
            case 14:
                return dialogue.Treasure_Hunter();
            case 15:
                return dialogue.Chaos();
            case 16:
                return dialogue.WorkShop();
            case 17:
                return dialogue.RangeVar_Tutorial();
            case 18:
                return dialogue.Librarian();
            case 19:
                return dialogue.Camping();
            default:
                return null;
        }
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) GetHint() {
        if (hints == null) {
            hints = new Hint();
        }

        switch (task_number) {
            case 0:
                return hints.Tutorial1();
            case 1:
                return hints.Tutorial2();
            case 2:
                return hints.Tutorial3();
            case 3:
                return hints.Tutorial4();
            case 4:
                return hints.Tutorial5();
            case 5:
                return hints.Registration_Form();
            case 6:
                return hints.GoToSchool();
            case 7:
                return hints.Science_Lesson();
            case 8:
                return hints.Tidy_Up();
            case 9:
                return hints.Shopping();
            case 10:
                return hints.Detective_Tutorial(); 
            case 11:
                return hints.Cooking_Lesson();
            case 12:
                return hints.Sport_Lesson();
            case 13:
                return hints.BigTask_Tutorial();
            case 14:
                return hints.Treasure_Hunter(); 
            case 15:
                return hints.Chaos();
            case 16:
                return hints.WorkShop();
            case 17:
                return hints.RangeVar_Tutorial(); 
            case 18:
                return hints.Librarian(); 
            case 19:
                return hints.Camping(); 
            default:
                return (null, null, null);
        }
    }

    public int GetSubTaskNum(){
        return current_subtask;
    }

    public void SetSubTaskNum(){
        current_subtask += 1;
        LoadNextTask();
    }

    public int GetSubTaskTotal(){
        return subtask_num;
    }

    public void AddToPackPack(Combined_Card_Info card) {
        backpack_cards.Add(card);
        GameObject.FindGameObjectWithTag("event_system").GetComponent<Search_System>().UpdateCards();
    }

    public void RemoveFromPackPack(int num) {
        backpack_cards.RemoveAt(num);
        GameObject.FindGameObjectWithTag("event_system").GetComponent<Search_System>().UpdateCards();
    }

    public void SetTask(int num) {
        task_number = num;
    }

    public void SetTaskTopic() {
        Top_Bar top = GameObject.Find("TopBar").GetComponent<Top_Bar>();
        switch (task_number) {
            case 0:
                top.SetTaskName("Task 0: Tutorial");
                break;
            case 1:
                top.SetTaskName("Task 1: Variable Concept");
                break;
            case 2:
                top.SetTaskName("Task 2: Condition, Comparison and Logic");
                break;
            case 3:
                top.SetTaskName("Task 3: Looping");
                break;
            case 4:
                top.SetTaskName("Task 4: Hint System");
                break;
            case 5:
                top.SetTaskName("Task 5: Registration");
                break;
            case 6:
                top.SetTaskName("Task 6: Go to School");
                break;
            case 7:
                top.SetTaskName("Task 7: Science Lesson");
                break;
            case 8:
                top.SetTaskName("Task 8: Tidy up the house");
                break;
            case 9:
                top.SetTaskName("Task 9: Shopping");
                break;
            case 10:
                top.SetTaskName("Task 10: Detective System");
                break;
            case 11:
                top.SetTaskName("Task 11: Cooking Lesson");
                break;
            case 12:
                top.SetTaskName("Task 12: Sport Lesson");
                break;
            case 13:
                top.SetTaskName("Task 13: Big Task Tutorial");
                break;
            case 14:
                top.SetTaskName("Task 14: Treasure Hunter");
                break;
            case 15:
                top.SetTaskName("Task 15: Chaos");
                break;
            case 16:
                top.SetTaskName("Task 16: WorkShop");
                break;
            case 17:
                top.SetTaskName("Task 17: RangeVar");
                break;
            case 18:
                top.SetTaskName("Task 18: Librarian");
                break;
            case 19:
                top.SetTaskName("Task 19: Camping");
                break;
        }
        backpack_cards = new List<Combined_Card_Info>();

        //testing
        current_subtask = 0;

        GetAnswer();
        object_sprite_list = GetObjectSprites();
        for (int i = 0; i < object_sprite_list.Count; i++) {
            submitted_concept_info.Add(new List<Concept_Info>());
        }     
    }

    public int GetTask() {
        return task_number;
    }

    public float GetAudioVol() {
        return audioVol;
    }

    public void SetAudioVol(float vol) {
        audioVol = vol;
    }

    public void InitialTask() {
        backpack_cards = new List<Combined_Card_Info>();

        submitted_concept_info = new List<List<Concept_Info>>();
        for (int i = 0; i < object_sprite_list.Count; i++) {
            submitted_concept_info.Add(new List<Concept_Info>());
        }

        SceneManager.LoadScene("SampleScene");
        current_subtask = 0;
    }

    private void LoadNextTask() {
        if (GameObject.FindGameObjectWithTag("event_system") != null) {
            GameObject.FindGameObjectWithTag("event_system").GetComponent<Search_System>().UpdateCards();
        }
        GameObject.Find("TaskPage").GetComponent<Task_System>().UpdateScene();
    }

    public void AddCurrentAnswer(List<List<Concept_Info>> info) {
        submitted_concept_info = info;
    }

    public List<List<Concept_Info>> GetCurrentAnswer() {
        return submitted_concept_info;
    }

    public void Blur_Screen() {
        GameObject panel = Instantiate(blur_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);
    }

    public void UnBlur_Screen() {
        Destroy(GameObject.Find("Blur_Panel"));
    }

    public void Menu_Blur_Screen() {
        GameObject panel = Instantiate(menu_blur_panel, GameObject.FindGameObjectWithTag("Canvas").transform);
        panel.name = panel.name.Replace("(Clone)","").Trim();
        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        panel.transform.position = new Vector3(center.x,center.y,0);    
    }

    public void Menu_UnBlur_Screen() {
        Destroy(GameObject.Find("Menu_Blur_Panel"));
    }

    public void PlaySound(int num) {
        AudioSource sound_source = GetComponent<AudioSource>();
        AudioClip sound = sounds[num];
        
        sound_source.clip = sound;
        sound_source.volume = audioVol;
        sound_source.Play();
    }

    public int GetTaskCompleted() {
        return task_completed;
    }

    public int GetTaskTotal() {
        return task_total;
    }

    public void SetCurrentActivePage(int num) {
        current_active_page = num;
    }

    public int GetCurrentActivePage() {
        return current_active_page;
    }

    public void SetPlayerStatus() {
        task_completed += 1;
        database_script.UpdatePlayerSetting(task_completed, audioVol);
    }

    public void SetPlayerTime() {
        database_script.SetPlayerTime(DateTime.Now);
    }

    public string GetPlayerFirstTime() {
        return database_script.GetPlayerTime();
    }

    public List<(int, string, string, List<Combined_Card_Info>)> GetDetectCards() {
        if (detective_cards == null) {
            detective_cards = new Detective_Item();
        }

        if (task_number > 9) {
            switch (task_number){
                case 10:
                    return detective_cards.Detective_Tutorial();
                case 11:
                    return detective_cards.Cooking_Lesson();
                case 12:
                    return detective_cards.Sport_Lesson();
                case 13:
                    return detective_cards.BigTask_Tutorial();
                case 14:
                    return detective_cards.Treasure_Hunter();
                case 15:
                    return detective_cards.Chaos();
                case 16:
                    return detective_cards.WorkShop();
                case 17:
                    return detective_cards.RangeVar_Tutorial();
                case 18:
                    return detective_cards.Librarian();
                case 19:
                    return detective_cards.Camping();
            }
        }

        return null;
    }
}
