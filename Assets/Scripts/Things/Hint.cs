using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint
{
    //Storage of all task hint list
    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Tutorial1() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 2);
        title[0][0].Add("Tutorial_Task");
        title[0][1].Add("Tutorial_Task");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 2);
        info[0][0].Add("Just follow the dialogue!");
        info[0][1].Add("Just follow the dialogue!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 2);
        hint[0][0].Add(new List<int> {});
        hint[0][1].Add(new List<int> {});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Tutorial2() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 3);
        title[0][0].Add("Tutorial_Task");
        title[0][1].Add("Tutorial_Task");
        title[0][2].Add("Tutorial_Task");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 3);
        info[0][0].Add("Just follow the dialogue!");
        info[0][1].Add("Just follow the dialogue!");
        info[0][2].Add("Just follow the dialogue!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 3);
        hint[0][0].Add(new List<int> {});
        hint[0][1].Add(new List<int> {});
        hint[0][2].Add(new List<int> {});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Tutorial3() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 7);
        title[0][0].Add("Tutorial_Task");
        title[0][1].Add("Tutorial_Task");
        title[0][2].Add("Tutorial_Task");
        title[0][3].Add("Tutorial_Task");
        title[0][4].Add("Tutorial_Task");
        title[0][5].Add("Tutorial_Task");
        title[0][6].Add("Tutorial_Task");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 7);
        info[0][0].Add("Just follow the dialogue!");
        info[0][1].Add("Just follow the dialogue!");
        info[0][2].Add("Just follow the dialogue!");
        info[0][3].Add("Just follow the dialogue!");
        info[0][4].Add("Just follow the dialogue!");
        info[0][5].Add("Just follow the dialogue!");
        info[0][6].Add("Just follow the dialogue!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 7);
        hint[0][0].Add(new List<int> {});
        hint[0][1].Add(new List<int> {});
        hint[0][2].Add(new List<int> {});
        hint[0][3].Add(new List<int> {});
        hint[0][4].Add(new List<int> {});
        hint[0][5].Add(new List<int> {});
        hint[0][6].Add(new List<int> {});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Tutorial4() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 5);
        title[0][0].Add("Tutorial_Task");
        title[0][1].Add("Tutorial_Task");
        title[0][2].Add("Tutorial_Task");
        title[0][3].Add("Tutorial_Task");
        title[0][4].Add("Tutorial_Task");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 5);
        info[0][0].Add("Just follow the dialogue!");
        info[0][1].Add("Just follow the dialogue!");
        info[0][2].Add("Just follow the dialogue!");
        info[0][3].Add("Just follow the dialogue!");
        info[0][4].Add("Just follow the dialogue!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 5);
        hint[0][0].Add(new List<int> {});
        hint[0][1].Add(new List<int> {});
        hint[0][2].Add(new List<int> {});
        hint[0][3].Add(new List<int> {});
        hint[0][4].Add(new List<int> {});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Tutorial5() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 3);
        title[0][0].Add("Requirement");
        title[0][1].Add("Requirement");
        title[0][1].Add("Requirement");
        title[0][2].Add("Requirement");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 3);
        info[0][0].Add("I need a Engine!");
        info[0][1].Add("I need a Gear 2!");
        info[0][1].Add("I need a Gear 1!");
        info[0][2].Add("The value I need to check is the grape's value!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 3);
        hint[0][0].Add(new List<int> {8});
        hint[0][1].Add(new List<int> {8});
        hint[0][1].Add(new List<int> {8});
        hint[0][2].Add(new List<int> {1,2,3,8});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Registration_Form() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 3);
        title[0][0].Add("Hint");
        title[0][1].Add("Hint");
        title[0][2].Add("Hint");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 3);
        info[0][0].Add("Let me give you a hint: I need a variable that contains your name as a value — the required type you should already know!");
        info[0][1].Add("In this game, you can break the If-Else to two If statements! That means you need to submit two concepts: If statement.");
        info[0][2].Add("This time, you don't need to handle break and continue.");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 3);
        hint[0][0].Add(new List<int> {5});
        hint[0][1].Add(new List<int> {1,2,3,4,7,8});
        hint[0][2].Add(new List<int> {0,1,2,3,4,7,8,9});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) GoToSchool() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 6);
        title[0][0].Add("SchoolBag!");
        title[0][1].Add("Hint");
        title[0][2].Add("Octopus Card");
        title[0][3].Add("Assignment");
        title[0][4].Add("Score");
        title[0][5].Add("Leave the Bus");

        title.Add(NewCharacter());
        AddNewScene(title[1], 6);
        title[1][5].Add("Leave the Bus");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 6);
        info[0][0].Add("I need the schoolbag!");
        info[0][1].Add("If bus arrives, enter the bus. If not, play mobile games.");
        info[0][2].Add("Where is my octopus card?");
        info[0][3].Add("It should be Math and English.");
        info[0][4].Add("I think it may be 2?");
        info[0][5].Add("Quick! Pack the schoolbag, stand up and run!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 6);
        info[1][5].Add("Quick! Pack the schoolbag, stand up and run!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 6);
        hint[0][0].Add(new List<int> {8});
        hint[0][1].Add(new List<int> {1,4,7});
        hint[0][2].Add(new List<int> {1,2,3,4,7,8});
        hint[0][3].Add(new List<int> {6,8});
        hint[0][4].Add(new List<int> {2,3,5,8});
        hint[0][5].Add(new List<int> {6,7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 6);
        hint[1][5].Add(new List<int> {6,7});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Science_Lesson() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 9);
        title[0][0].Add("Just follow!");
        title[0][1].Add("Just follow!");
        title[0][2].Add("Just follow!");
        title[0][3].Add("Just follow!");
        title[0][4].Add("Just follow!");
        title[0][5].Add("Just follow!");
        title[0][8].Add("Just follow!");

        title.Add(NewCharacter());
        AddNewScene(title[1], 9);
        title[1][0].Add("Just follow!");
        title[1][1].Add("Just follow!");
        title[1][3].Add("Just follow!");
        title[1][4].Add("Just follow!");
        title[1][5].Add("Just follow!");
        title[1][6].Add("Just follow!");
        title[1][7].Add("Just follow!");
        title[1][8].Add("Just follow!");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 9);
        info[0][0].Add("Just follow the instruction!");
        info[0][1].Add("Just follow the instruction!");
        info[0][2].Add("Just follow the instruction!");
        info[0][3].Add("Just follow the instruction!");
        info[0][4].Add("Just follow the instruction!");
        info[0][5].Add("Just follow the instruction!");
        info[0][8].Add("Just follow the instruction!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 9);
        info[1][0].Add("Just follow the instruction!");
        info[1][1].Add("Just follow the instruction!");
        info[1][3].Add("Just follow the instruction!");
        info[1][4].Add("Just follow the instruction!");
        info[1][5].Add("Just follow the instruction!");
        info[1][6].Add("Just follow the instruction!");
        info[1][7].Add("Just follow the instruction!");
        info[1][8].Add("Just follow the instruction!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 9);
        hint[0][0].Add(new List<int> {7});
        hint[0][1].Add(new List<int> {7});
        hint[0][2].Add(new List<int> {1,2,3,4,7,8});
        hint[0][3].Add(new List<int> {0,7,9});
        hint[0][4].Add(new List<int> {7});
        hint[0][5].Add(new List<int> {7});
        hint[0][8].Add(new List<int> {7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 9);
        hint[1][0].Add(new List<int> {7});
        hint[1][1].Add(new List<int> {7});
        hint[1][3].Add(new List<int> {7});
        hint[1][4].Add(new List<int> {7});
        hint[1][5].Add(new List<int> {7});
        hint[1][6].Add(new List<int> {0,7,9});
        hint[1][7].Add(new List<int> {1,2,3,4,7,8});
        hint[1][8].Add(new List<int> {7});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Tidy_Up() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 6);
        title[0][0].Add("Clean bookshelf");
        title[0][1].Add("Check the book");
        title[0][3].Add("Check food expired date");
        title[0][5].Add("Shopping list");

        title.Add(NewCharacter());
        AddNewScene(title[1], 6);
        title[1][2].Add("Throw the book");
        title[1][4].Add("Check the area");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 6);
        info[0][0].Add("Let me see if the item on bookshelf is dust...");
        info[0][1].Add("Let me see if these 20 books are useful or not...");
        info[0][3].Add("Let me see... throw away the food that is expired, and I can stop when the current food is not expired as the food are placed in order!");
        info[0][5].Add("Let me write down the things that need to be bought in order...");

        info.Add(NewCharacter());
        AddNewScene(info[1], 6);
        info[1][2].Add("Give me the book you don't need in order!");
        info[1][4].Add("Where is it not clean?");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 6);
        hint[0][0].Add(new List<int> {1,2,3,4,7,8});
        hint[0][1].Add(new List<int> {0,1,2,3,4,7,8,9});
        hint[0][3].Add(new List<int> {0,1,2,3,4,7,8,9});
        hint[0][5].Add(new List<int> {6,8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 6);
        hint[1][2].Add(new List<int> {6,8});
        hint[1][4].Add(new List<int> {8});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Shopping() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 6);
        title[0][0].Add("Thinking");
        title[0][2].Add("Food");
        title[0][3].Add("Thinking");
        title[0][4].Add("Buy things");
        title[0][5].Add("Hint");

        title.Add(NewCharacter());
        AddNewScene(title[1], 6);
        title[1][2].Add("Food");

        title.Add(NewCharacter());
        AddNewScene(title[2], 6);
        title[2][1].Add("Number");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 6);
        info[0][0].Add("I am so hungry...");
        info[0][2].Add("Let's read the menu and see which food to order. * After finding the suitable food, there is no need to read it anymore!");
        info[0][3].Add("Let buy the things I need!");
        info[0][4].Add("Hint: You can buy things using the Buy Things Action!");
        info[0][5].Add("* Noticed that you should use variables to answer this question. Here are some hints. \"Left\" means turn to the left. \"Walk 1\" means walk 1 step. Please place your plan in a container.");

        info.Add(NewCharacter());
        AddNewScene(info[1], 6);
        info[1][2].Add("Let's read the menu and see which food to order. * After finding the suitable food, there is no need to read it anymore!");

        info.Add(NewCharacter());
        AddNewScene(info[2], 6);
        info[2][1].Add("How many people?");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 6);
        hint[0][0].Add(new List<int> {8});
        hint[0][2].Add(new List<int> {0,1,2,3,4,7,8,9});
        hint[0][3].Add(new List<int> {8});
        hint[0][4].Add(new List<int> {6,7});
        hint[0][5].Add(new List<int> {5,6});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 6);
        hint[1][2].Add(new List<int> {0,1,2,3,4,7,8,9});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[2], 6);
        hint[2][1].Add(new List<int> {5});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Detective_Tutorial() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 5);
        title[0][0].Add("Just Follow!");
        title[0][1].Add("Just Follow!");
        title[0][2].Add("Just Follow!");
        title[0][3].Add("Just Follow!");
        title[0][4].Add("Just Follow!");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 5);
        info[0][0].Add("Just follow the instruction!");
        info[0][1].Add("Just follow the instruction!");
        info[0][2].Add("Just follow the instruction!");
        info[0][3].Add("Just follow the instruction!");
        info[0][4].Add("Just follow the instruction!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 5);
        hint[0][0].Add(new List<int> {7});
        hint[0][1].Add(new List<int> {8});
        hint[0][2].Add(new List<int> {8});
        hint[0][3].Add(new List<int> {2,3,5,8});
        hint[0][4].Add(new List<int> {1,2,3,4,5,7,8});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Cooking_Lesson() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 7);
        title[0][0].Add("Recipe");
        title[0][2].Add("Hint");
        title[0][4].Add("Hint");
        title[0][5].Add("Shape of molds");

        title.Add(NewCharacter());
        AddNewScene(title[1], 7);
        title[1][1].Add("Ingradients");
        title[1][2].Add("Hint");
        title[1][3].Add("Hint");
        title[1][6].Add("Hint");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 7);
        info[0][0].Add("I need the recipe, where is it?");
        info[0][2].Add("Format of action is:\nAction -> Ingredients/Products -> End\n\nHint: Remember the relation of container and order or item!");
        info[0][4].Add("Format of action is:\nAction -> Ingredients/Products -> End\n\nHint: Remember the relation of container and order or item!");
        info[0][5].Add("I need the star and the apple shape molds!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 7);
        info[0][0].Add("Let me see what I need...\n- Flour\n- Leaveners\n- Butter\n- Sugar- \nEgg\n- Vanilla");
        info[1][2].Add("Format of action is:\nAction -> Ingredients/Products -> End\n\nHint: Remember the relation of container and order or item!");
        info[1][3].Add("Format of action is:\nAction -> Ingredients/Products -> End\n\nHint: Remember the relation of container and order or item!");
        info[1][6].Add("Format of action 'Put In':\nAction -> Ingredients/Products -> Place -> End\n\nHint: Remember the relation of container and order or item!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 7);
        hint[0][0].Add(new List<int> {8});
        hint[0][2].Add(new List<int> {6,7,8});
        hint[0][4].Add(new List<int> {6,7,8});
        hint[0][5].Add(new List<int> {8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 7);
        hint[1][1].Add(new List<int> {8});
        hint[1][2].Add(new List<int> {6,7,8});
        hint[1][3].Add(new List<int> {6,7,8});
        hint[1][6].Add(new List<int> {8});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Sport_Lesson() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 7);
        title[0][0].Add("Place to go");
        title[0][1].Add("Needed Item");
        title[0][2].Add("Rule");
        title[0][3].Add("Place to go");
        title[0][4].Add("Member");
        title[0][5].Add("Rule");
        title[0][6].Add("Place to go");

        title.Add(NewCharacter());
        AddNewScene(title[1], 7);
        title[1][0].Add("Place to go");
        title[1][1].Add("Needed Item");
        title[1][3].Add("Place to go");
        title[1][4].Add("Member");
        title[1][6].Add("Place to go");

        title.Add(NewCharacter());
        AddNewScene(title[2], 7);
        title[2][6].Add("Place to go");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 7);
        info[0][0].Add("Where should I go?");
        info[0][1].Add("Let get a racket!");
        info[0][2].Add("Hint: Check the left first and then check the right!");
        info[0][3].Add("Where should I go?");
        info[0][4].Add("Whose are in this team?");
        info[0][5].Add("I am not good at shooting the ball, I prefer passing instead of shooting!");
        info[0][6].Add("Where should I go?");

        info.Add(NewCharacter());
        AddNewScene(info[1], 7);
        info[1][0].Add("Where should I go?");
        info[1][1].Add("Let get a racket! Also, is my turn!");
        info[1][3].Add("Where should I go?");
        info[1][4].Add("Whose are in this team?");
        info[1][6].Add("Where should I go?");

        info.Add(NewCharacter());
        AddNewScene(info[2], 7);
        info[2][6].Add("Where should I go?");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 7);
        hint[0][0].Add(new List<int> {8});
        hint[0][1].Add(new List<int> {8});
        hint[0][2].Add(new List<int> {0,1,4,7});
        hint[0][3].Add(new List<int> {8});
        hint[0][4].Add(new List<int> {8});
        hint[0][5].Add(new List<int> {0,1,4,7,8});
        hint[0][6].Add(new List<int> {8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 7);
        hint[1][0].Add(new List<int> {8});
        hint[1][1].Add(new List<int> {8});
        hint[1][3].Add(new List<int> {8});
        hint[1][4].Add(new List<int> {8});
        hint[1][6].Add(new List<int> {8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[2], 7);
        hint[2][6].Add(new List<int> {8});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) BigTask_Tutorial() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 1);
        title[0][0].Add("Thing A");
        title[0][0].Add("Thing B");

        title.Add(NewCharacter());
        AddNewScene(title[1], 1);
        title[1][0].Add("Thing A");
        title[1][0].Add("Thing B");

        title.Add(NewCharacter());
        AddNewScene(title[2], 1);
        title[2][0].Add("Sick");

        title.Add(NewCharacter());
        AddNewScene(title[3], 1);
        title[3][0].Add("Thing A");
        title[3][0].Add("Thing B");

        title.Add(NewCharacter());
        AddNewScene(title[4], 1);
        title[4][0].Add("Thing A");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 1);
        info[0][0].Add("If I want to order the food, I can just order!");
        info[0][0].Add("If I finish my lunch, I need to go to the counter and pay!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 1);
        info[1][0].Add("If customer want to order the food, I go to that table and receive the order!");
        info[1][0].Add("If the food is finished, I go to the pickup area and pick up the food. Then, I will go to the customer's table to place down their food!");

        info.Add(NewCharacter());
        AddNewScene(info[2], 1);
        info[2][0].Add("I am sick and cannot go back to work...");

        info.Add(NewCharacter());
        AddNewScene(info[3], 1);
        info[3][0].Add("If restaurant has a new order, I will read the order and start cooking until the food is ready!");
        info[3][0].Add("If the food is finished, I will put it on the plate. Then, I will go to the pickup area to place down the food and call the waiter!");

        info.Add(NewCharacter());
        AddNewScene(info[4], 1);
        info[4][0].Add("If customers arrive, I will help them finish the pay process!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 1);
        hint[0][0].Add(new List<int> {1,4,7,8});
        hint[0][0].Add(new List<int> {1,4,7,8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 1);
        hint[1][0].Add(new List<int> {1,4,7,8});
        hint[1][0].Add(new List<int> {1,4,7,8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[2], 1);
        hint[2][0].Add(new List<int> {});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[3], 1);
        hint[3][0].Add(new List<int> {1,4,7,8});
        hint[3][0].Add(new List<int> {0,1,4,7,8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[4], 1);
        hint[3][0].Add(new List<int> {1,4,7});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Treasure_Hunter() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 10);
        title[0][1].Add("Place to go");
        title[0][2].Add("Place to go");
        title[0][3].Add("Activity");
        title[0][4].Add("Place to go");
        title[0][6].Add("Place to go");
        title[0][7].Add("Activity");
        title[0][8].Add("Place to go");
        title[0][9].Add("Place to go");

        title.Add(NewCharacter());
        AddNewScene(title[1], 10);
        title[1][7].Add("Activity");

        title.Add(NewCharacter());
        AddNewScene(title[2], 10);
        title[2][0].Add("Team");
        title[2][5].Add("Activity");
        title[2][7].Add("Activity");

        title.Add(NewCharacter());
        AddNewScene(title[3], 10);

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 10);
        info[0][1].Add("Where should I go?");
        info[0][2].Add("Where should I go?");
        info[0][3].Add("Let me finish this task!");
        info[0][4].Add("Where should I go? Anything I need to do?");
        info[0][6].Add("Where should I go? Anything I need to do?");
        info[0][7].Add("I love listening to music.");
        info[0][8].Add("Where is the stamp?");
        info[0][9].Add("Where should I go? Anything I need to do?");

        info.Add(NewCharacter());
        AddNewScene(info[1], 10);
        info[1][7].Add("I am sporty!");

        info.Add(NewCharacter());
        AddNewScene(info[2], 10);
        info[2][0].Add("This is our team!");
        info[2][5].Add("Let me finish this task!");
        info[2][7].Add("I am good at science!");

        info.Add(NewCharacter());
        AddNewScene(info[3], 10);

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 10);
        hint[0][1].Add(new List<int> {7});
        hint[0][2].Add(new List<int> {7});
        hint[0][3].Add(new List<int> {0,1,4,7,8,9});
        hint[0][4].Add(new List<int> {7});
        hint[0][6].Add(new List<int> {7});
        hint[0][7].Add(new List<int> {7});
        hint[0][8].Add(new List<int> {7});
        hint[0][9].Add(new List<int> {7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 10);
        hint[1][7].Add(new List<int> {7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[2], 10);
        hint[2][0].Add(new List<int> {8});
        hint[2][5].Add(new List<int> {0,1,7,8});
        hint[2][7].Add(new List<int> {7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[3], 10);

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Chaos() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 2);
        title[0][0].Add("Hint");
        title[0][1].Add("Hint");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 2);
        info[0][0].Add("Check carefully and follow the instruction!");
        info[0][1].Add("Check carefully and follow the instruction!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 2);
        hint[0][0].Add(new List<int> {1,4,7,8});
        hint[0][1].Add(new List<int> {7});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) WorkShop() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 1);
        title[0][0].Add("Task A");
        title[0][0].Add("Task B");

        title.Add(NewCharacter());
        AddNewScene(title[1], 1);
        title[1][0].Add("Task A");

        title.Add(NewCharacter());
        AddNewScene(title[2], 1);
        title[2][0].Add("Thing needed");

        title.Add(NewCharacter());
        AddNewScene(title[3], 1);
        title[2][0].Add("Thing needed");
        title[1][0].Add("Task A");

        title.Add(NewCharacter());
        AddNewScene(title[4], 1);
        title[1][0].Add("Task A");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 1);
        info[0][0].Add("Before I call the teacher to go down and test, I need to clean the whole room and set it up first!\n\nAh! I need to clean the room at the end as well!");
        info[0][0].Add("Once I finish the rehearsal, I need to confirm the rundown!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 1);
        info[1][0].Add("Let me see... I need to set up the route on the first floor.");

        info.Add(NewCharacter());
        AddNewScene(info[2], 1);
        info[2][0].Add("Let's set up a new event here! I need a camera, board, camera stand... I also need the microphone, tables and chairs. Just give me all of the things, I can handle that");

        info.Add(NewCharacter());
        AddNewScene(info[3], 1);
        info[3][0].Add("Let's finish the decoration! I need 2 display board, a poster and a LED monitor. Just give me all of the things, I can handle that");
        info[3][0].Add("I need to read the whole guideline first. After that, I will set up the decorations one by one");

        info.Add(NewCharacter());
        AddNewScene(info[4], 1);
        info[4][0].Add("I need to practice my skill! Tomorrow, I will stand at the entrance.");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 1);
        hint[0][0].Add(new List<int> {6,7});
        hint[0][0].Add(new List<int> {1,4,7,8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 1);
        hint[1][0].Add(new List<int> {6,7});


        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[2], 1);
        hint[2][0].Add(new List<int> {8});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[3], 1);
        hint[3][0].Add(new List<int> {8});
        hint[3][0].Add(new List<int> {0,6,7,9});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[4], 1);
        hint[4][0].Add(new List<int> {7});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) RangeVar_Tutorial() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 4);
        title[0][0].Add("Hint");
        title[0][1].Add("Hint");
        title[0][2].Add("Hint");
        title[0][3].Add("Hint");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 4);
        info[0][0].Add("Follow the instruction!");
        info[0][1].Add("Follow the instruction!");
        info[0][2].Add("Follow the instruction!");
        info[0][3].Add("Follow the instruction!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 4);
        hint[0][0].Add(new List<int> {5,9});
        hint[0][1].Add(new List<int> {5,9});
        hint[0][2].Add(new List<int> {5,8,9});
        hint[0][3].Add(new List<int> {5,8,9});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Librarian() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 6);
        title[0][0].Add("Take the book");
        title[0][1].Add("Put the book");
        title[0][2].Add("Borrow");
        title[0][3].Add("Return");
        title[0][4].Add("Check the book");
        title[0][5].Add("End");

        title.Add(NewCharacter());
        AddNewScene(title[1], 6);

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 6);
        info[0][0].Add("I need to go down to take the book and then go back here!");
        info[0][1].Add("For each book shelf, for each unorganized book, I need to check and put the book.");
        info[0][2].Add("Help the student borrow all the books!");
        info[0][3].Add("Help the student return all the books!");
        info[0][4].Add("For each borrowed book, if the book is expired, I need to send the letter.");
        info[0][5].Add("I need to close the library and go back to the classroom!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 6);

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 6);
        hint[0][0].Add(new List<int> {6,7});
        hint[0][1].Add(new List<int> {0,5,7,8,9});
        hint[0][2].Add(new List<int> {0,5,7,8,9});
        hint[0][3].Add(new List<int> {0,5,7,8,9});
        hint[0][4].Add(new List<int> {0,1,2,3,4,5,7,8,9});
        hint[0][5].Add(new List<int> {6,7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 6);

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Camping() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 1);
        title[0][0].Add("Set Up tent");

        title.Add(NewCharacter());
        AddNewScene(title[1], 1);
        title[1][0].Add("Fire!");

        title.Add(NewCharacter());
        AddNewScene(title[2], 1);
        title[2][0].Add("Multiple things!");

        title.Add(NewCharacter());
        AddNewScene(title[3], 1);
        title[3][0].Add("Task");

        title.Add(NewCharacter());
        AddNewScene(title[4], 1);
        title[4][0].Add("Take the food");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 1);
        info[0][0].Add("I need to go to the camping site. Let me see the steps for setting up the tent on the internet!\nHint: Remember if we use container, order will be important!");

        info.Add(NewCharacter());
        AddNewScene(info[1], 1);
        info[1][0].Add("Let me go to the camping site to get the charcoal and lighter first. Then, I need to light a fire for barbecue!\nHint: Remember, if we use container, order will be important!");

        info.Add(NewCharacter());
        AddNewScene(info[2], 1);
        info[2][0].Add("First, I need to check in. After that, I can go to the barbecue site and help clean the table. If the food arrives, I will unpack all the food.\nHint: Remember, if we use container, order will be important!");

        info.Add(NewCharacter());
        AddNewScene(info[3], 1);
        info[3][0].Add("Let me help James!\nHint: Remember, if we use container, order will be important!");

        info.Add(NewCharacter());
        AddNewScene(info[4], 1);
        info[4][0].Add("I need to pick up:\nbarbecue fork\nhoney\nfood pack A\nfood pack C\nfood pack D\n and go to the babecue site!\nHint: Remember if we use container, order will be important!");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 1);
        hint[0][0].Add(new List<int> {6,7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[1], 1);
        hint[1][0].Add(new List<int> {6,7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[2], 1);
        hint[2][0].Add(new List<int> {0,1,4,5,6,7,8,9});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[3], 1);
        hint[3][0].Add(new List<int> {6,7});

        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[4], 1);
        hint[4][0].Add(new List<int> {6,7});

        return (title, info, hint);
    }

    public (List<List<List<string>>>, List<List<List<string>>>, List<List<List<List<int>>>>) Sample() {
        List<List<List<string>>> title = NewThings();
        title.Add(NewCharacter());
        AddNewScene(title[0], 6);
        title[0][0].Add("Thinking");

        List<List<List<string>>> info = NewThings();
        info.Add(NewCharacter());
        AddNewScene(info[0], 6);
        info[0][0].Add("I am so hungry...");

        List<List<List<List<int>>>> hint = NewHints();
        hint.Add(NewHintsCharacter());
        AddNewHintScene(hint[0], 6);
        hint[0][0].Add(new List<int> {8});

        return (title, info, hint);
    }

    public List<List<List<string>>> NewThings() {
        return new List<List<List<string>>>();
    }
    public List<List<string>> NewCharacter() {
        return new List<List<string>>();
    }
    public List<string> NewScene() {
        return new List<string>();
    }

    public List<List<List<List<int>>>> NewHints() {
        return new List<List<List<List<int>>>>();
    }

    public List<List<List<int>>> NewHintsCharacter() {
        return new List<List<List<int>>>();
    }

    public List<List<int>> NewHintsScene() {
        return new List<List<int>>();
    }

    public void AddNewScene(List<List<string>> l, int num) {
        for (int i = 0; i < num; i++) {
            l.Add(NewScene());
        }
    }

    public void AddNewHintScene(List<List<List<int>>> l, int num) {
        for (int i = 0; i < num; i++) {
            l.Add(NewHintsScene());
        }
    }
}

