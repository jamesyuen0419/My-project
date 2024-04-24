using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskDialogue
{
    //Storage of all task dialogue
    List<string> dialogue;

    public List<string> Tutorial1() {
        dialogue = new List<string>();
        string dia = "Helper: Hello! User! Here is the control system. I am glad to help you understand this system!\n\n" +
                     "Helper: First, can you press the support button on the top right corner(Light Bulb Button) to see how to control this system?\n\n" +
                     "Helper: After you finish reading the tutorial and understand every part of the system, let's try some easy tasks!\n\n" + 
                     "Subtask 1: Please give a variable to the Helper:\n" +
                     "Type : String\n" +
                     "Value: Hello\n";               
        dialogue.Add(dia);
        dia = "Helper: Great! You are correct!How about this?\n\n" +
              "Subtask2: Can you give helper a container with two items?\n\n" +
              "Item 1: Variable\n"+
              "Type : String\n" +
              "Value: Hello\n\n"+
              "Item 2: Variable\n"+
              "Type : Integer\n" +
              "Value: 123\n";
        dialogue.Add(dia);
        return dialogue;
    }

    public List<string> Tutorial2() {
        dialogue = new List<string>();
        string dia = "Helper: Hello! User! This time we will learn the variable concept, which you already saw in Task 0!\n\n" +
                     "Helper: Variable are one of the fundamental concepts we will use in programming.\n\n" +
                     "Helper: You can go to the search page first to learn more about variable like type and value!\n\n" +
                     "Helper: Is it easy, right? How about we try on some easy tasks to see if you really understand this concept?\n\n" +
                     "[System - task 1]\n" +
                     "Helper want to have a variable with type Character and value 'a'.";
        dialogue.Add(dia);
        dia = "Helper: Good! Let's try another task!\n\n" +
              "[System - task 2]\n" +
              "Helper want to have a variable with type String and value 'Hello'.";
        dialogue.Add(dia);
        dia = "Helper: Great! Next, let's try an example of a numeric value!\n\n" +
              "[System - task 3]\n" +
              "Helper want to have 2 variables, one with value 10 and another with value 10.5";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Tutorial3() {
        dialogue = new List<string>();
        string dia = "Helper: In this task, we will learn condition, comparison and logic.\n\n" +
                     "Helper: If you don't know what these concepts are, you can go to the tutorial page and read their brief description.\n\n" +
                     "Helper: Condition always used to check whether a requirement is fulfilled or not. This is represented by two values in Boolean type: True and False.\n\n" +
                     "Helper: You can find them in Logic concept part. Can you give me a false and a true concept?";
        dialogue.Add(dia);
        dia = "Helper: Good! Let's continue the teaching! There are two common cases for a condition:\n\n" +
              "Helper: 1. Some variables or objects that contain a boolean value.\n\n" +
              "Helper: 2. A comparison that we are going to learn.\n\n" +
              "Helper: We always use comparison to see whether a value is what we expected. In the comparison, we will use some operators that are in Logic concept.\n" +
              "Helper: Let's start with some tasks! Can you give me an operator that can place in the dash in this equation?\n" +
              "Helper: Equation: 3 _ 1";
        dialogue.Add(dia);
        dia = "Helper: Of Course 3 is bigger than 1! How about this equation?\n\n" +
              "Helper: Equation: (3 - 2) _ 1";
        dialogue.Add(dia);
        dia = "Helper: So let's start some complicated tasks about comparison!\n\n" +
              "Helper: Condition: Tom Age > Peter Age";
        dialogue.Add(dia);
        dia = "Helper: Good Job! In comparison, we can also put variables inside. Let's try this one!\n\n" +
              "Helper: Condition: Tom Age > 10 (10 in this case is a variable with type integer)";
        dialogue.Add(dia);
        dia = "Helper: It seems that you understand the concept very well! Lastly, we introduce two more operators, And and Or.\n\n" +
              "Helper: In comparison, we can combine different comparisons together. Here is a simple description of these two concepts:\n\n" +
              "Helper: And: If all comparisons are True, the final result is true; otherwise, False\n\n" +
              "Helper: Or: If at least one comparison is True, the final result will be True. Only all comparisons that are Flase will return False.\n\n" +
              "Helper: Let's start some tasks to understand these two operators!\n\n" +
              "Helper: Condition: True And True";
        dialogue.Add(dia);
        dia = "Helper: Great! How about this?\n\n" +
              "Helper: Condition: True Or False";
        dialogue.Add(dia);

      return dialogue;
    }

    public List<string> Tutorial4() {
        dialogue = new List<string>();
        string dia = "Helper: Hi! User! Glad to see you. In this task, I will introduce the new concept Looping.\n\n" +
                     "Helper: Looping consists of a number of concepts. First of all, if you forget what a condition is, you can check the tutorial page!\n\n" +
                     "Helper: If you're ready, let's start the task! As mentioned in the tutorial page, it can be briefly divided into 4 parts: Looping Condition, Actions, Break Condition and Continue Condition.\n\n" +
                     "Helper: There are two common ways to set up a condition for Looping. First, use the range concept to restrict the number of iterations. It contains the start and end, as well as one important concept - interval.\n\n" +
                     "Helper: Task: Please give me a range concept that start from 1 to 10. If we put it into the loop, the loop should run 5 times. Interval should set to what? (Hint: if interval is set to 1, every iteration will increase the value by 1. e.g. 1 -> 2 -> 3...)";
        dialogue.Add(dia);
        dia = "Helper: You are correct! If we set interval to 2. The range will be 1, 3, 5, 7, 9. Noted that 9 + 2 = 11 and 11 > 10 (end value) so it will stop the loop immediately.\n\n" +
              "Helper: Another way to set the condition of a loop is to check if a condition is true or not. Remember this? It is a comparison! Here is a simple task to check if you remember comparison.\n\n" +
              "Helper: Task: Please give me a comparison that Tom Age < 10";
        dialogue.Add(dia);
        dia = "Helper: Good Job! Remember, we need to put it into a condition concept before modifying the Looping concept! However, for Range concept, we do not need to put it inside the condition concept!\n\n" +
              "Helper: OK! Let's start with some complicated tasks. The basic part of Looping included two parts: The Looping Condition we already tried and some actions you may want to add in every iteration.\n\n" +
              "Helper: Actions can include different kinds of concepts, like action, If statement or even a Looping inside a Looping!\n\n" +
              "Helper: Task: Please give me a Looping Concept:\n" +
              "Looping Condition: range start from 10 to 20 with interval 1\n" +
              "Actions: Say HI";
        dialogue.Add(dia);
        dia = "Helper: Nice! It seems that you understand what Looping is!\n\n" +
              "Helper: Let me introduce two more conditions to you. In a looping concept, sometimes we want to stop in the middle and stop the remaining iteration. In this case, we need to give a break condition.\n\n" +
              "Helper: Task: Please give me a Looping Concept:\n" +
              "Looping Condition: range start from 1 to 100 with interval 1" +
              "Actions: Say HI" +
              "Break Condition:  Looping Value == 10 (Hint: == means equals to, Looping value can find from Object Concept)";
        dialogue.Add(dia);
        dia = "Helper: Good Job! Also, we may want to skip some iterations inside the whole loop. To do that, we need to set up a continue condition.\n" +
              "Helper: Task: Please give me a Looping Concept:" +
              "Looping Condition: range start from 1 to 50 with interval 5" +
              "Action 1: Say HI" +
              "Action 2: Say Bye" +
              "Break Condition:  Looping Value == 10" +
              "Continue Condition: Looping Value > 30";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Registration_Form() {
        dialogue = new List<string>();
        string dia = "Helper: Congratulation! You finished the tutorial task!\n\n" +
                     "Helper: Let's start with the first task!\n\n" +
                     "System: New task - Registration\n" +
                     "System: Task Target - Please finish the registration.\n\n" +
                     "Helper: This is just a normal task, so I think you can handle it very well!\n\n" +
                     "Helper: First, you need to write down your name.";
        dialogue.Add(dia);
        dia = "Helper: Of course, it is a string type! Good Job! Next, you need to fill in your gender.\n\n" +
              "Helper: The action description is: If your gender is equal to male, check the male box. Otherwise, check the female box.";
        dialogue.Add(dia);
        dia = "Helper: You did it! Lastly, you need to fill in your age. How about we use a loop with a range from 1 to 100 and an interval of 1 to represent this action?\n\n" +
              "Helper: Inside the loop, if the age shown is equal to your age, click This is my age button.";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> GoToSchool() {
        dialogue = new List<string>();
        string dia = "Helper: Hello! Is me again! In the later tasks, you need to help the characters finish their work by using the concepts!\n\n" +
                     "Helper: Try to understand what they want and give them the correct concepts!\n\n" +
                     "System: New task - Go to school\n" +
                     "System: Task Target - Is time to start the school day!\n\n" +
                     "Mum: Tom, it's time to go to school!\n\n" +
                     "Tom: OK, mum.\n\n" +
                     "Mum: Don't forget your school bag!\n\n" +
                     "Tom: Oh, I almost forget it. Where is my school bag?\n\n" +
                     "[System - task 1]\n" +
                     "Give Tom his school bag.";
        dialogue.Add(dia);
        dia = "Tom: Oh, is here! Time to go, bye mum ~\n\n" +
              "Tom: Umm, it seems that the bus has not yet arrived. Let's wait and play my new mobile game!\n\n" +
              "[System - task 2]\n" +
              "Give Tom 2 concepts. If bus arrives, enter the bus. If not, play mobile games.";
        dialogue.Add(dia);
        dia = "Tom: ...Finally, the bus arrives. Let me find my octopus card.\n\n" +
              "[System - task 3]\n" +
              "Give Tom a concept. If bag's item is octopus card, take it out.";
        dialogue.Add(dia);
        dia = "Tom: Oh, is here!\n\n" +
              "Herry: HI, Tom! Good to see you!\n\n" +
              "Tom: HI, Herry! Can I sit here?\n\n" +
              "Herry: Of course! By the way, you remember that we need to hand in what assignment?\n\n" +
              "Tom: Umm......\n\n" +
              "[System - task 4]\n" +
              "Remind Tom they need to hand what assignement. Please pack them up properly with a container in order.";
        dialogue.Add(dia);
        dia = "Tom: Ah! Math and English homework! Do you finish all of them?\n\n" +
              "Herry: Yup! It's quite easy. Tom, you know yesterday Team tiger won the football match?!\n\n" +
              "Tom: Really? Yesterday I was doing my revision and I didn't notice that! Which team were they facing?\n\n" +
              "Herry: Team giraffe. You guess Team tiger got how many score?\n\n" +
              "Tom: Let me see......(maybe 2?)\n\n" +
              "[System - task 5]\n" +
              "Tom want to guess score equal to 2. Give him a correct concept!";
        dialogue.Add(dia);
        dia = "Tom: Umm... maybe 2?\n\n" +
              "Herry: Is 4! Honestly I didn't think they can do that!\n\n" +
              "Tom: Wow! Team tiger did a really good job! Oh Herry! We have already arrived! Quick!\n\n" +
              "Herry! Let's grab the school bag and run!\n\n" +
              "[System - task 6]\n" +
              "Please pack the corresponding actions into a container and give it to Tom and Herry! It should have 3 action in total!";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Science_Lesson() {
        dialogue = new List<string>();
        string dia = "System: New task - Science lesson\n" +
                     "System: Task Target - Please help Tom and Herry finish a Chemistry experiment!\n\n" +
                     "Tom: Herry, what is the next lesson?\n\n" +
                     "Herry: Chemistry lesson. I remember that today's lesson is in the science lab.\n\n" +
                     "(Ring... Ring...)\n\n" +
                     "Tom: It's time for the Chemistry lesson. Let's go!\n\n" +
                     "Teacher: Today, we will do an experiment. First, you can see that we have four chemicals on your table, name as bottle A, B, C, D.\n\n" +
                     "Teacher: Please follow my steps to finish the experiment today.\n\n" + 
                     "Experiment Start: \n" +
                     "Step 1:\nTom pick up chemical A.\nHerry pick up chemical B.";
        dialogue.Add(dia);
        dia = "Step 2:\nTom pour chemical A to beaker A.\nHerry pour chemical B to beaker A.\nTom mix them together.";
        dialogue.Add(dia);
        dia = "Step 3:\nTom check if the mixed chemical's color changed. If yes, pick up chemical C and pour it into beaker A.";
        dialogue.Add(dia);
        dia = "Step 4:\nHerry mix the chemicals together.\nTom pick up the chemical D.\nTom pour chemical D to the beaker A for 10 time every 1 second, start from 5.";
        dialogue.Add(dia);
        dia = "Step 5:\nHerry come out and take the bunsen burner.\nTom come out and take the tripod.";
        dialogue.Add(dia);
        dia = "Step 6:\nHerry set up the things.\nTom place beaker A on the tripod.";
        dialogue.Add(dia);
        dia = "Step 7:\nHerry pour chemical C to the beaker A every 2 second. Start from 1 and you need to pour 10 times.";
        dialogue.Add(dia);
        dia = "Step 8:\nHerry check if color of chemical in the bottle is red, pour the mixed checmical to beaker B.";
        dialogue.Add(dia);
        dia = "Step 9:\nTom submit the beaker.\nHerry clear the table.";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Tidy_Up() {
        dialogue = new List<string>();
        string dia = "System: New task - Tidy up the house\n" +
                     "System: Task Target - Please help Tom and his mom tidy up their house!\n\n" +
                     "Mom: It's time to tidy up, Tom.\n\n" +
                     "Tom: Sure mom, what do I need to do first?\n\n" +
                     "Mom: Please clean the book shelf in your bedroom first.\n\n" +
                     "[System - task 1]\n" +
                     "There is lots of dust on the book shelf. If you see the dust, please clean it.";
        dialogue.Add(dia);
        dia = "Tom: (Start cleaning)...\nFinally finish the work!\n\n" +
              "Tom: Oh! It seems that there are some books on the book shelf, is time to throw them away.\n\n" +
              "[System - task 2]\n" +
              "There are 20 books on the book shelf which are start from book 1. If the book are not useful, take it out.";
        dialogue.Add(dia);
        dia = "Mom: Are there any things you need to throw away?\n\n" +
              "Tom: Yes, mom. These books are not useful now.\n\n" +
              "[System - task 3]\n" +
              "Please pack Book 1, 3, 6 and 10 together in order and give it to Tom's mom.";
        dialogue.Add(dia);
        dia = "Tom: Any things I can do to help you also, mom?\n\n" +
              "Mom: Of course! Please help me see if there are any foods that are expired and throw them away. I remember that the foods in the cabinet are arranged in order according to their expiration dates.\n\n" +
              "[System - task 4]\n" +
              "Please check the food are expired or not. The food's number start from 1 and the last one is number 15. If you see a food is not yet expired, you don't need to check the others and stop.";
        dialogue.Add(dia);
        dia = "Mom: Umm... Any furniture or places are still not cleaned?\n\n" +
              "Tom: Let me see...\n\n" +
              "[System - task 5]\n" +
              "Please check if all the places or things are tidy up and tell Tom's mom about the things that are not cleaned. There are located in the Object!";
        dialogue.Add(dia);
        dia = "Mom: Oh, I almost forgot that. Thanks son. I remember that you need to go out, right?\n\n" +
              "Tom: Yup, I go with Herry in the afternoon.\n\n" +
              "Mom: Can you help me buy something before you get back home?\n\n" +
              "Tom: Sure!\n\n" +
              "[System - task 6]\n" +
              "Please bring a list of things you need to buy before you go out. They included: apples, pears and the toilet paper";
        dialogue.Add(dia);    

      return dialogue;
    }

    public List<string> Shopping() {
        dialogue = new List<string>();
        string dia = "System: New task - Shopping\n" +
                     "System: Task Target - Please help Tom and herry finish the shopping process!\n\n" +
                     "Herry: Hey Tom, here!\n\n" +
                     "Tom: Sorry for being late.\n\n" +
                     "Herry: It's fine. Where we go first?\n\n" +
                     "Tom: Umm... I am a bit hungry...\n\n" +
                     "[System - task 1]\n" +
                     "Help Herry answer which place go first.";
        dialogue.Add(dia);
        dia = "Herry: How about we go to restaurant A first?\n\n" +
              "Tom: Yup!\n\n" +
              "(Walking to Restaurant A...)\n\n" +
              "Waiter: Welcome! How many people?\n\n" +
              "[System - task 2]\n" +
              "Help them answer waiter's question.";
        dialogue.Add(dia);
        dia = "Tom: 2.\n\n" +
              "Waiter: OK! You guys can sit here. Here is our menu.\n\n" +
              "Tom & Herry: Thank you. Let me see...\n\n" +
              "[System - task 3]\n" +
              "Create a action for Tom and Herry to read the menu and tell the waiter which food they will order. The menu contains 10 pages and start from page 1.";
        dialogue.Add(dia);
        dia = "(Tom & Herry finish ordering and eating...)\n\n" +
              "Tom: Your recommendation is good! This restaurant is on my favorite list now.\n\n" +
              "Herry: Ya! This restaurant is very good! Tom, next we go to the toy store to see the newly released figures?\n\n" +
              "Tom: Before we go to the toy store, I need to buy some stuff ordered by my mom first.\n\n" +
              "[System - task 4]\n" +
              "Help Tom answer which place go then.";
        dialogue.Add(dia);
        dia = "(Walking to Supermarket...)\n\n" +
              "Herry: What things do you need to buy?\n\n" +
              "Tom: Apples, pears... and toilet paper.\n\n" +
              "Herry: I remember that fruit section B and toilet paper can be found in section C.\n\n" +
              "[System - task 5]\n" +
              "Please help Tom to create a plan to buy all these food.\nRequirement 1: Tom want to buy fruit first.\nRequirement 2: Plan should stored in a container.";
        dialogue.Add(dia);
        dia = "(Paying...)\n\n" +
              "Tom: Alright, is time to go the toy store!\n\n" +
              "Herry: Nice!\n\n" +
              "(Walking to the Toy Store...)\n\n" +
              "Tom: Where is the new figure section?\n\n" +
              "[System - task 6]\n" +
              "Please help tom to create a route to the figure section. Here is the route description.\n\nTurn Right -> Walk 10 steps -> Turn Left -> Walk 5 Steps -> Turn Left -> Walk 10 Step";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Detective_Tutorial() {
        dialogue = new List<string>();
        string dia = "Helper: HI, is me again!\n\n" +
                     "Helper: Congratulations! You finished a number of tasks!\n\n" +
                     "Helper: Here is a new system you can use!\n\n" +
                     "Helper: In the function mode, you can now go to the third mode, Detective Mode.\n\n" +
                     "Helper: In the later tasks, sometimes the concepts are not shown directly and you need to use this mode to find some useful concepts in order to build your answer!\n\n" +
                     "In the detective panel, you can click on the things on the panel and see their descriptions. Then, you can click the check button and retrieve the concept you want by clicking the add button.\n\n" +
                     "[System - task 1]\n" +
                     "Helper want to get Mark's action";
        dialogue.Add(dia);
        dia = "Helper: Good Job! Let's try something more!\n\n" +
              "[System - task 2]\n" +
              "Helper want to get the running speed of Mark.";
        dialogue.Add(dia);
        dia = "Helper: Before handling some advanced tutorials, let's try one more task!\n\n" +
              "[System - task 3]\n" +
              "Helper want to know something related to Joy.";
        dialogue.Add(dia);
        dia = "Helper: It seems that you understand how the system work, let's use the concepts in this new system to build some concepts!\n\n" +
              "[System - task 4]\n" +
              "Helper wish to get a comparison concept to check if the value of Mark's running speed larger than 10.";
        dialogue.Add(dia);
        dia = "Helper: Good! Let's try one more to see if you really understand the new system!\n\n" +
              "[System - task 5]\n" +
              "Helper want to check if the value of Mark's running speed larger than 10. If yes, say HI to Joy.";
        dialogue.Add(dia);    
      return dialogue;
    }

    public List<string> Cooking_Lesson() {
        dialogue = new List<string>();
        string dia = "System: New task - Cooking Lesson\n" +
                     "System: Task Target - Help Herry and James finish the cooking lesson at school.\n\n" +
                     "Teacher: HI everyone! Today we will try to make cookies. Please take the recipe and follow the steps.\n\n" +
                     "[System - task 1]\n" +
                     "Please help Herry get the recipe from their teacher.";
        dialogue.Add(dia);
        dia = "Herry: Let me see... First, we should take the ingredients. Those gradients should be put inside those ingredient boxes.\n\n" +
              "James: OK! Let me grab the ingredients first.\n\n" +
              "[System - task 2]\n" +
              "James needs to take the correct ingredients.";
        dialogue.Add(dia);
        dia = "James: These should be enough.\n\n" +
              "Herry: Great! Step 1 is to put sugar, butter, egg and vanilla in one bowl. Another person mix flour and leaveners in another bowl.\n\n" +
              "James: OK. I will handle the second one.\n\n" +
              "[System - task 3]\n" +
              "Please help Herry and James finish Step 1. The action procedure should be placed inside the container!\nFormat of action is:\nAction -> Ingredients/Products -> End";
        dialogue.Add(dia);
        dia = "Herry: I finished the work. How about you?\n\n" +
              "James: I just finished. Let me blend the flour mixture and butter mixture together.\n\n" +
              "[System - task 4]\n" +
              "Help James finish Step 2.The action procedure should be placed inside the container and position of ingredients should follow the order.\nFormat of action is:\nAction -> Ingredients/Products -> End";
        dialogue.Add(dia);
        dia = "Herry: Next, we should roll the final mixture into a ball. Let me finish this.\n\n" +
              "[System - task 5]\n" +
              "Help Herry finish step 3. The action procedure should be placed inside the container.\nFormat of action is:\nAction -> Ingredients/Products -> End";
        dialogue.Add(dia);
         dia = "Herry: Good! Let me take some cookie molds from the tool box to make them look more beautiful.\n\n" +
               "James: Good idea! Let's take the star and apple shapes.\n\n" +
               "[System - task 6]\n" +
               "Help Herry take the correct cookie molds";
        dialogue.Add(dia);
        dia = "Herry: Here we go! These cookies look great!\n\n" +
              "James: Yea agree. Let me see what the next step... The last step is to put the cookies in the oven.\n\n" +
              "[System - task 7]\n" +
              "Help James finish the last step! The action procedure should be placed inside the container.\nNoticed that the Format of action 'Put In' is Action -> Ingredients/Products -> Place -> End";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Sport_Lesson() {
        dialogue = new List<string>();
        string dia = "System: New task - Sport Lesson\n" +
                     "System: Task Target - Enjoy the Sport Lesson with Tom and Herry!\n\n" +
                     "Sport Teacher: Hey Hey Hey! Please keep quiet first! Does everyone arrive? Good! Today is a special lesson as we are having a lesson in this stadium!\n\n" +
                     "Sport Teacher: You guys remember that you guys cannot go outside the stadium, and at 12:30 pm, you should wait at the entrance, and we will go back to the school. Is that clear?\n\n" +
                     "All Students: Yes Sir!\n\n" +
                     "Sport Teacher: Good! Let's enjoy your sport lesson!\n\n" +
                     "Tom: Hey Herry, where we go first?\n\n" +
                     "Herry: Maybe we can play badminton first?\n\n" +
                     "Tom: Alright.\n\n" +
                     "[System - task 1]\n" +
                     "Please guild Tom and Herry to the right place.";
        dialogue.Add(dia);
        dia = "Tom: It seems that we are the first group to enter here. Let's grab the badminton racket and the shuttle.\n\n" +
              "Herry: OK! Let me serve first!\n\n" +
              "[System - task 2]\n" +
              "Please give the requirement items to Tom and Herry.";
        dialogue.Add(dia);
        dia = "[System - task 3]\n" +
              "Please give a concept to Herry for action 'Play Badminton'.Noticed that the order of situation to be checked should be left -> right\nHint of concept needed:\nshuttle not hit the ground - Condition\nshuttle on the left side - Condition\nshuttle on the right side - Condition\nhit the shuttle on the left - Action\nhit the shuttle on the right - Action";
        dialogue.Add(dia);
        dia = "Herry: Good game! This time I still lose to you...\n\n" +
              "Tom: Ha Ha! Let's see if you can beat me next time.\n\n" +
              "Herry: How about we go to watch a basketball match?\n\n" +
              "Tom: Yea! Let go!\n\n" +
              "[System - task 4]\n" +
              "Please guild Tom and Herry to the right place.";
        dialogue.Add(dia);
        dia = "Tom: Wow! Good game! Can we join you guys in the next match?\n\n" +
              "Peter: Of course! We have six people right now. How about we have a 3 VS 3 match?\n\n" +
              "Herry: Sure. Maybe we two with Peter on the red side and you guys on the blue side?\n\n" +
              "Blue Team: OK!\n\n" +
              "[System - task 5]\n" +
              "Help them form the group.";
        dialogue.Add(dia);
        dia = "[System - task 6]\n" +
              "Please give a concept to Herry for action 'Play Basketball'. Noticed that shoot have a higher pirority than pass\nHint of concept needed:\nteammate want the ball - Condition\npass the ball - Action\nduring the match - Condition\ntime to shoot - Condition\nshoot - Action\neither group reach 20 scores - Condition";
        dialogue.Add(dia);
        dia = "Tom: Good work, Peter and Herry!\n\n" +
              "Peter: Nice shoot!\n\n" +
              "Herry: What a good game! Oh! The time is 12:20 right now, is time to go!\n\n" +
              "[System - task 7]\n" +
              "Please guild Tom, Peter and Herry to the right place.";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Tutorial5() {
        dialogue = new List<string>();
        string dia = "Helper: Hello User! This time I will introduce a system - Hint System which is located on top of this dialogue system.\n\n" +
                     "Helper: This hint system will provide more detail about different tasks. You can click the character name and see their personal task in the subtasks. Also, you can click on the task to see the description and find some hints!\n\n" +
                     "Helper: To confirm you really understand the use of the hint system, let's try some easy tasks.\n\n" +
                     "[System - task 1]\n" +
                     "Please give me the thing I want.";
        dialogue.Add(dia);
        dia = "Helper: Great! How about with multiple characters?\n\n" +
              "[System - task 2]\n" +
              "Please give us the thing we want.";
        dialogue.Add(dia);
        dia = "Helper: Wow! You really understand how this system works! Before finishing this task, how about we try one more simple subtask?\n\n" +
              "[System - task 3]\n" +
              "Helper want to get a condition to check where something value is higher than the Apple's Value";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> BigTask_Tutorial() {
        dialogue = new List<string>();
        string dia = "Helper: HI, is me again!\n\n" +
                     "Helper: I am so happy that you have passed so many tasks! It seems that you can handle a more difficult task!\n\n" +
                     "Helper: In the later tasks, there will be some big subtasks to finish. It will have multiple characters, and you need to submit a number of concepts.\n\n" +
                     "Helper: In those subtasks, make sure you make use of the Hint System to understand what each character wants! Also, check all the provided materials in Action, Object and Detective System etc. to see what you can use in that task. Let's try a big subtask.\n\n" +
                     "[System - task 1]\n" +
                     "Finish a Action 'Serve a customer in a restaurant'";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Treasure_Hunter() {
        dialogue = new List<string>();
        string dia = "System: New task - Treasure Hunter\n" +
                     "System: Task Target - The school organizes a treasure hunter game, and your mission is to help Tom and his friends finish the game.\n\n" +
                     "Tom: Today is the treasure hunter game, do you guys form a group?\n\n" +
                     "Herry: Nope. I think we can form together!\n\n" +
                     "Peter: Yup! Let's write down our names on the blackboard. Umm... let's choose group C.\n\n" +
                     "[System - task 1]\n" +
                     "Hand in the memeber names to the mentioned group.";
        dialogue.Add(dia);
        dia = "Teacher: If you guys have formed the group already, please arrive the ground floor and wait for the game to start.\n\n" +
              "[System - task 2]\n" +
              "Go to the correct place.";
        dialogue.Add(dia);
        dia = "Teacher: Alright, keep quiet! Listen carefully. Today you need to finish three missions in order to win the game. When you finish the mission, remember to stamp your group cards. Once your group finishes all three tasks, come back and tell me you guys are finished. Is that clear?\n\n" +
              "Students: Yea!\n\n" +
              "Tom: Herry, where is the first mission?\n\n" +
              "Herry: Let me see... It should be on the first floor.\n\n" +
              "[System - task 3]\n" +
              "Go to the correct place.";
        dialogue.Add(dia);
        dia = "Herry: Hello, what do we need to do here.\n\n" +
              "Teacher Helper: You can see that there are 10 obstacles on the ground labeled as 1 - 10. For each obstacle, if it is red in color, hop through it; if it is blue in color, jump through it.\n\n" +
              "Tom: Let me handle this task.\n\n" +
              "[System - task 4]\n" +
              "Form the correct concept.";
        dialogue.Add(dia);
        dia = "Teacher Helper: Good Job! Here is the stamp. The next mission is on the third floor.\n\n" +
              "[System - task 5]\n" +
              "Go to the correct place.";
        dialogue.Add(dia);
        dia = "Teacher Helper: HI students! Here is Mission 2. Please finish the tangram.\n\n" +
              "Peter: This time let me finish it!\n\n" +
              "[System - task 6]\n" +
              "Form the correct concept.";
        dialogue.Add(dia);
        dia = "Teacher Helper: Congratulation! Your last task is on the second floor!\n\n" +
              "[System - task 7]\n" +
              "Go to the correct place.";
        dialogue.Add(dia);
        dia = "Teacher Helper: You guys finish the tasks so quickly! Here is the last mission, you guys need to work together to complete this task.\n\n" +
              "Tom: Let's discuss who handles each part!\n\n" +
              "[System - task 8]\n" +
              "Form the correct concept.";
        dialogue.Add(dia);
        dia = "Teacher Helper: Congratulations! You finished all the tasks! Remember that you guys need to do something to end this game!\n\n" +
              "[System - task 9]\n" +
              "Go to the correct place and end the game.";
        dialogue.Add(dia);
        dia = "Teacher Helper: Oh! I am sorry. I forgot to take out the stamp! Let me help you... OK, here are your cards!\n\n" +
              "[System - task 10]\n" +
              "Go to the correct place and end the game.";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Chaos() {
        dialogue = new List<string>();
        string dia = "Helper: Hello! Is me! In the last task, you can see that the instructions from the system in a subtask are wrong! It is not a bug in this game, but this is a new feature I want to introduce to you!\n\n" +
                     "Helper: Theoretically, a program should run as normal and we should get the expected result. However, sometimes it may not work due to some external elements! For example, in the previous task, Teacher Helper forgot to take the stamp, so we could not just stamp on the card!\n\n" +
                     "Helper: Compiler do not expect unexpected behavior, and your provided concept may not work as you think! In this case, we will call it a 'Chaos State', and you need to think about how to use the given sources to finish those tasks!\n\n" +
                     "Helper: In order to test your understanding, please finish some chaos state tasks.\n\n" +
                     "[System - task 1]\n" +
                     "Say HI to me.";
        dialogue.Add(dia);
        dia = "Helper: Good! Let try another one!\n\n" +
              "[System - task 2]\n" +
              "Say Bye to me.";
        dialogue.Add(dia);

      return dialogue;
    }

    public List<string> WorkShop() {
        dialogue = new List<string>();
        string dia = "System: New task - Organizing School Workshop\n" +
                     "System: Task Target - Tom and his friends going to organize a work shop related to good eating habits. Please help them to finish the preparation of the workshop.\n\n" +
                     "Tom: Today is the time to finish our workshop preparation. Just follow the plan we have made, which should be OK.\n\n" +
                     "Herry: Yup, we have marked down all the things we need to finish. Let's start the work!\n\n" +
                     "[System - task 1]\n" +
                     "Please finish all the required preparation. Noticed that this task is a long task, you should check the given concept and also use the hint system to form all the concepts. (Hint: If some work need to do in order, use a specific concept to manage them.)";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> RangeVar_Tutorial() {
        dialogue = new List<string>();
        string dia = "Helper: Hello User! I am here to help you understand an advanced concept related to Looping. It is similar to Range but this time we use variable or obejct inside the concept!\n\n" +
                     "Helper: The new concept is called Range_Var where Var stands for Variable. You can see it in the Looping Concept area. Just like Range. Start will be a Integer value, interval will either be a Integer or Float value. However, this time End is not only an Integer value, but also can be a Object Concept to indicate the upper bound!\n\n" +
                     "Helper: Let's try some exercises to see if you understand what Range_Var does!\n\n" +
                     "[System - task 1]\n" +
                     "Form a Range Concept using Range_Var Concept with start = 1, end = 5, interval = 1.";
        dialogue.Add(dia);
        dia = "[System - task 2]\n" +
              "Form a Range Concept using Range_Var Concept with start = 1, end = 10, interval = 0.5.";
        dialogue.Add(dia);
        dia = "Helper: Good! How about using Object Concept also!\n\n" +
              "[System - task 3]\n" +
              "Form a Range_Var Concept with start = 1, end = Helper's height, interval = 1.";
        dialogue.Add(dia);
        dia = "[System - task 4]\n" +
              "Form a Range_Var Concept with start = 1, end = Number of apples, interval = 1.5.";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Librarian() {
        dialogue = new List<string>();
        string dia = "System: New task - Being a librarian\n" +
                     "System: Task Target - Help Tom finish his librarian's work.\n\n" +
                     "Tom: Alright, let's start today's work. I remember that some new books arrived this morning. Let's take the books here first.\n\n" +
                     "[System - task 1]\n" +
                     "Help Tom takes the book to the library.";
        dialogue.Add(dia);
        dia = "Tom: Finally, bring all the books here. Is time to put the book in the right place on the bookshelves.\n\n" +
              "[System - task 2]\n" +
              "Help Tom put all the books to the bookshelves.";
        dialogue.Add(dia);
        dia = "Tom: Last one... Ok, all the books are in their positions!\n\n" +
              "Student: Is the librarian here?\n\n" +
              "Tom: Yup! Anything I can help you with?\n\n" +
              "Student: Can I borrow these books?\n\n" +
              "Tom: Of course! Let me help you!\n\n" +
              "[System - task 3]\n" +
              "Help Tom finish the action 'Borrow Book'.";
        dialogue.Add(dia);
        dia = "Tom: Oh, you already exceeded the limit on borrowing books!\n\n" +
              "Student: Ah! I forgot to return the books first. Here are the books I borrowed.\n\n" +
              "[System - task 4]\n" +
              "Help Tom finish the action 'Return Book'.";
        dialogue.Add(dia);
        dia = "Student: Thank you very much!\n\n" +
              "Tom: Have a good day!\n\n" +
              "(Student is leaving...)\n\n" +
              "Tom: Is time to check if some books are overdue. If yes, I need to send an email to those students.\n\n"+
              "[System - task 5]\n" +
              "Help Tom finish the action 'Checking'.";
        dialogue.Add(dia);
        dia = "(School bell ring...)\n\n" +
              "Tom: Is time for the lesson. Let's close the door and leave.\n\n" +
              "[System - task 5]\n" +
              "Let end the librarian work!";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Camping() {
        dialogue = new List<string>();
        string dia = "System: New task - Camping\n" +
                     "System: Task Target - Let enjoy a camping event with Tom and his friends.\n\n" +
                     "Tom: We arrive! The environment looks so good!\n\n" +
                     "Herry: Ya! How about we set up the things we need first?\n\n" +
                     "[System - task 1]\n" +
                     "Please finish the event 'Set Up'";
        dialogue.Add(dia);
      return dialogue;
    }

    public List<string> Dialogue() {
        dialogue = new List<string>();
        string dia = "Helper: \n\n" +
                     "Helper: ";
        dialogue.Add(dia);
        dia = "Helper:\n" +
              "Helper:";
        dialogue.Add(dia);
        dia = "Helper: \n" +
              "Helper: ";
        dialogue.Add(dia);
      return dialogue;
    }
}
