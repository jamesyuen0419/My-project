using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionAndObject
{
    public (List<Action_Info>, List<Object_Info>) Tutorial1() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {

        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Tutorial2() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {

        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Tutorial3() {
        List<Action_Info> actions = new List<Action_Info>
        {
           
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Tom Age"),
            new Object_Info("Peter Age")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Tutorial4() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Say HI"),
            new Action_Info("Say bye")
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Looping Value")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Registration_Form() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Check Male Box"),
            new Action_Info("Check Female Box"),
            new Action_Info("Click This is my age Button")
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Your Gender"),
            new Object_Info("Male"),
            new Object_Info("Female"),
            new Object_Info("Your Age"),
            new Object_Info("Age Shown")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) GoToSchool() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Bus arrives"),
            new Action_Info("Bus not yet arrived"),
            new Action_Info("Enter the bus"),
            new Action_Info("Play mobile games"),
            new Action_Info("Take out"),
            new Action_Info("Put in"),
            new Action_Info("Get out the bus"),
            new Action_Info("Grab the school bag"),
            new Action_Info("Stand up")
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("school bag"),
            new Object_Info("home's key"),
            new Object_Info("bag's item"),
            new Object_Info("octopus card"),
            new Object_Info("Math assignment"),
            new Object_Info("Chinese assignment"),
            new Object_Info("English assignment"),
            new Object_Info("tiger's score"),
            new Object_Info("giraffe's score")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Science_Lesson() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Pick up A"),
            new Action_Info("Pour A to beaker A"),
            new Action_Info("Pick up B"),
            new Action_Info("Pour B to beaker A"),
            new Action_Info("Pick up C"),
            new Action_Info("Pour C to beaker A"),
            new Action_Info("Pick up D"),
            new Action_Info("Pour D to beaker A"),
            new Action_Info("Mix beaker A"),
            new Action_Info("Take bunsen burner"),
            new Action_Info("Take tripod"),
            new Action_Info("Place on the tripod"),
            new Action_Info("Pour chemical to beaker B"),
            new Action_Info("Set up"),
            new Action_Info("Submit"),
            new Action_Info("Clear the table")
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Chemical color"),
            new Object_Info("Expected chemical color"),
            new Object_Info("Green"), 
            new Object_Info("Red"),
            new Object_Info("Blue")         
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Tidy_Up() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Clean it"),
            new Action_Info("Take it out"),
            new Action_Info("Throw it away")
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Dust"),
            new Object_Info("Book shelf's item"),
            new Object_Info("Book"),
            new Object_Info("Useful"),
            new Object_Info("Book 10"),
            new Object_Info("Book 3"),
            new Object_Info("Book 1"),
            new Object_Info("Book 5"),
            new Object_Info("Book 6"),
            new Object_Info("Food's expired date"),
            new Object_Info("Today's date"),
            new Object_Info("Wall - not cleaned"),
            new Object_Info("Book shelf - cleaned"),
            new Object_Info("Toilet - not cleaned"),
            new Object_Info("Apple"),
            new Object_Info("Earphone"),
            new Object_Info("Orange"),
            new Object_Info("Pear"),
            new Object_Info("Toilet paper")

        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Shopping() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Read Menu"),
            new Action_Info("Tell Waiter"),
            new Action_Info("Go Section A"),
            new Action_Info("Go Section B"),
            new Action_Info("Go Section C"),
            new Action_Info("Buy Things"),
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Restaurant"),
            new Object_Info("Food"),
            new Object_Info("Chosen Food"),
            new Object_Info("Toy Store"),
            new Object_Info("Supermarket"),
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Detective_Tutorial() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {

        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Cooking_Lesson() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Put"),
            new Action_Info("Mix"),
            new Action_Info("Blend"),
            new Action_Info("Roll"),
            new Action_Info("Put In"),
            new Action_Info("End")
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("flour mixture"),
            new Object_Info("butter mixture"),
            new Object_Info("final mixture"),
            new Object_Info("cookie")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Sport_Lesson() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Tom"),
            new Object_Info("Herry")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Tutorial5() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Engine"),
            new Object_Info("Gear 1"),
            new Object_Info("Gear 2"),
            new Object_Info("Apple's value"),
            new Object_Info("Banana's value"),
            new Object_Info("Grape's value"),
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) BigTask_Tutorial() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Order"),
            new Action_Info("Receive order"),
            new Action_Info("Read order"),
            new Action_Info("Cook"),
            new Action_Info("Pay"),
            new Action_Info("Finish pay process")  
        };
        List<Object_Info> objects = new List<Object_Info>
        {
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Treasure_Hunter() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Hop"),
            new Action_Info("Jump"),
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Tom"),
            new Object_Info("Herry"),
            new Object_Info("Peter"),
            new Object_Info("James")
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Chaos() {
        List<Action_Info> actions = new List<Action_Info>
        {
        };
        List<Object_Info> objects = new List<Object_Info>
        {
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) WorkShop() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Read the whole decoration guildline"),
            new Action_Info("Setup")
        };
        List<Object_Info> objects = new List<Object_Info>
        {

        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) RangeVar_Tutorial() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Helper's height"),
            new Object_Info("Number of apples"),
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Librarian() {
        List<Action_Info> actions = new List<Action_Info>
        {
            new Action_Info("Check and put the book on the bookshelf"),
            new Action_Info("Help borrow the book"),
            new Action_Info("Help return the book"),
            new Action_Info("Send letter"),
        };
        List<Object_Info> objects = new List<Object_Info>
        {
            new Object_Info("Today's Date"),
        };
        return (actions, objects);
    }

    public (List<Action_Info>, List<Object_Info>) Camping() {
        List<Action_Info> actions = new List<Action_Info>
        {

        };
        List<Object_Info> objects = new List<Object_Info>
        {

        };
        return (actions, objects);
    }
}
