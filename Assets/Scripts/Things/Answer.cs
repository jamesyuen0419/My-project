using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable] public class Answer
{
    //Storage of all task answer list
    List<List<List<Concept_Info>>> answer;

    public List<List<List<Concept_Info>>> Tutorial1() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Variable_Info ans01 = new Variable_Info("String", "Hello");
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        Variable_Info ans11 = new Variable_Info("String", "Hello");
        Variable_Info ans12 = new Variable_Info("Integer", "123");
        Container_Info con = new Container_Info(new List<Concept_Info> {ans11, ans12});
        answer[1][0].Add(con);

        return answer;
    }

    public List<List<List<Concept_Info>>> Tutorial2() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Variable_Info ans01 = new Variable_Info("Character", "a");
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        Variable_Info ans11 = new Variable_Info("String", "Hello");
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        Variable_Info ans21 = new Variable_Info("Integer", "10");
        Variable_Info ans22 = new Variable_Info("Float", "10.5");
        answer[2][0].Add(ans21);
        answer[2][0].Add(ans22);

        return answer;
    }

    public List<List<List<Concept_Info>>> Tutorial3() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Logic_Info ans01 = new Logic_Info("T");
        Logic_Info ans02 = new Logic_Info("F");
        answer[0][0].Add(ans01);
        answer[0][0].Add(ans02);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        Logic_Info ans11 = new Logic_Info(">");
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        Logic_Info ans21 = new Logic_Info("==");
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        answer[3].Add(NewObject());
        Comparison_Info ans31 = new Comparison_Info(new Object_Info("Tom Age"), new Object_Info("Peter Age"), new Logic_Info(">"));
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        answer[4].Add(NewObject());
        Comparison_Info ans41 = new Comparison_Info(new Object_Info("Tom Age"), new Variable_Info("Integer", "10"), new Logic_Info(">"));
        answer[4][0].Add(ans41);

        answer.Add(NewSubTask());
        answer[5].Add(NewObject());
        Comparison_Info ans51 = new Comparison_Info(new Logic_Info("T"), new Logic_Info("T"), new Logic_Info("&"));
        answer[5][0].Add(ans51);

        answer.Add(NewSubTask());
        answer[6].Add(NewObject());
        Comparison_Info ans61 = new Comparison_Info(new Logic_Info("T"), new Logic_Info("F"), new Logic_Info("|"));
        answer[6][0].Add(ans61);
        return answer;
    }

    public List<List<List<Concept_Info>>> Tutorial4() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Range_Info ans01 = new Range_Info(1,10,2);
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        Comparison_Info ans11 = new Comparison_Info(new Object_Info("Tom Age"), new Variable_Info("Integer", "10"), new Logic_Info("<"));
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        Looping_Info ans21 = new Looping_Info(new Range_Info(10,20,1), new List<Concept_Info> {new Action_Info("Say HI")}, null, null);
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        answer[3].Add(NewObject());
        Looping_Info ans31 = new Looping_Info(new Range_Info(1,100,1), new List<Concept_Info> {new Action_Info("Say HI")}, new Condition_Info(new Comparison_Info(new Object_Info("Looping Value"), new Variable_Info("Integer", "10"), new Logic_Info("=="))), null);
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        answer[4].Add(NewObject());
        Looping_Info ans41 = new Looping_Info(new Range_Info(1,50,5), new List<Concept_Info> {new Action_Info("Say HI"), new Action_Info("Say bye")}, new Condition_Info(new Comparison_Info(new Object_Info("Looping Value"), new Variable_Info("Integer", "10"), new Logic_Info("=="))), new Condition_Info(new Comparison_Info(new Object_Info("Looping Value"), new Variable_Info("Integer", "30"), new Logic_Info(">"))));
        answer[4][0].Add(ans41);
        return answer;
    }

    public List<List<List<Concept_Info>>> Registration_Form() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Variable_Info v0 = new Variable_Info("String", "Default");
        answer[0][0].Add(v0);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        If_Statement_Info if11 = new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Your Gender"), new Object_Info("Male"), new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Check Male Box")});        
        If_Statement_Info if12 = new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Your Gender"), new Object_Info("Female"), new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Check Female Box")}); 
        answer[1][0].Add(if11);
        answer[1][0].Add(if12);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        Looping_Info l2 = new Looping_Info(new Range_Info(1,100,1), new List<Concept_Info> {new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Age Shown"), new Object_Info("Your Age"), new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Click This is my age Button")})}, null, null);
        answer[2][0].Add(l2);

        return answer;
    }

    public List<List<List<Concept_Info>>> GoToSchool() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        Object_Info ans01 = new Object_Info("school bag");
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        If_Statement_Info ans11 = new If_Statement_Info(new Condition_Info(new Action_Info("Bus arrives")), new List<Concept_Info> {new Action_Info("Enter the bus")});
        If_Statement_Info ans12 = new If_Statement_Info(new Condition_Info(new Action_Info("Bus not yet arrived")), new List<Concept_Info> {new Action_Info("Play mobile games")});
        answer[1][0].Add(ans11);
        answer[1][0].Add(ans12);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],2);
        If_Statement_Info ans21 = new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("bag's item"),new Object_Info("octopus card"),new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Take out")});
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],2);
        Container_Info ans31 = new Container_Info(new List<Concept_Info> {new Object_Info("Math assignment"), new Object_Info("English assignment")});
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Comparison_Info ans41 = new Comparison_Info(new Object_Info("tiger's score"), new Variable_Info("Integer", "2"), new Logic_Info("=="));
        answer[4][0].Add(ans41);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],2);
        Container_Info ans51 = new Container_Info(new List<Concept_Info> {new Action_Info("Grab the school bag"), new Action_Info("Stand up"), new Action_Info("Get out the bus")});
        answer[5][0].Add(ans51);
        answer[5][1].Add(ans51);

        return answer;
    }

    public List<List<List<Concept_Info>>> Science_Lesson() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        Action_Info ans01 = new Action_Info("Pick up A");
        Action_Info ans02 = new Action_Info("Pick up B");
        answer[0][0].Add(ans01);
        answer[0][1].Add(ans02);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        Action_Info ans11 = new Action_Info("Pour A to beaker A");
        Action_Info ans12 = new Action_Info("Pour B to beaker A");
        Action_Info ans13 = new Action_Info("Mix beaker A");
        answer[1][0].Add(ans11);
        answer[1][0].Add(ans13);
        answer[1][1].Add(ans12);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],2);
        If_Statement_Info ans21 = new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Chemical color"),new Object_Info("Expected chemical color"),new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Pick up C"), new Action_Info("Pour C to beaker A")});
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],2);
        Action_Info ans31 = new Action_Info("Mix beaker A");
        Action_Info ans32 = new Action_Info("Pick up D");
        Looping_Info ans33 = new Looping_Info(new Range_Info(5, 14, 1), new List<Concept_Info> {new Action_Info("Pour D to beaker A")}, null, null);
        answer[3][1].Add(ans31);
        answer[3][0].Add(ans32);
        answer[3][0].Add(ans33);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Action_Info ans41 = new Action_Info("Take bunsen burner");
        Action_Info ans42 = new Action_Info("Take tripod");
        answer[4][1].Add(ans41);
        answer[4][0].Add(ans42);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],2);
        Action_Info ans51 = new Action_Info("Set up");
        Action_Info ans52 = new Action_Info("Place on the tripod");
        answer[5][1].Add(ans51);
        answer[5][0].Add(ans52);

        answer.Add(NewSubTask());
        AddNewObject(answer[6],2);
        Looping_Info ans61 = new Looping_Info(new Range_Info(1, 19, 2), new List<Concept_Info> {new Action_Info("Pour C to beaker A")}, null, null);
        answer[6][1].Add(ans61);

        answer.Add(NewSubTask());
        AddNewObject(answer[7],2);
        If_Statement_Info ans71 = new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Chemical color"), new Object_Info("Red"), new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Pour chemical to beaker B")});
        answer[7][1].Add(ans71);

        answer.Add(NewSubTask());
        AddNewObject(answer[8],2);
        Action_Info ans81 = new Action_Info("Submit");
        Action_Info ans82 = new Action_Info("Clear the table");
        answer[8][0].Add(ans81);
        answer[8][1].Add(ans82);

        return answer;
    }

    public List<List<List<Concept_Info>>> Tidy_Up() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        If_Statement_Info ans01 = new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Book shelf's item"), new Object_Info("Dust"), new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Clean it")});
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        Looping_Info ans11 = new Looping_Info(new Range_Info(1,20,1), new List<Concept_Info> {new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Book"),new Object_Info("Useful"),new Logic_Info("!="))), new List<Concept_Info> {new Action_Info("Take it out")})},null,null);
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],2);
        Container_Info ans21 = new Container_Info(new List<Concept_Info> {new Object_Info("Book 1"),new Object_Info("Book 3"),new Object_Info("Book 6"),new Object_Info("Book 10")});
        answer[2][1].Add(ans21);
        
        answer.Add(NewSubTask());
        AddNewObject(answer[3],2);
        Looping_Info ans31 = new Looping_Info(new Range_Info(1,15,1), new List<Concept_Info> {new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Food's expired date"),new Object_Info("Today's date"),new Logic_Info("<"))), new List<Concept_Info> {new Action_Info("Throw it away")})}, new Condition_Info(new Comparison_Info(new Object_Info("Food's expired date"),new Object_Info("Today's date"),new Logic_Info(">"))), null);
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Object_Info ans41 = new Object_Info("Wall - not cleaned");
        Object_Info ans42 = new Object_Info("Toilet - not cleaned");
        answer[4][1].Add(ans41);
        answer[4][1].Add(ans42);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],2);
        Container_Info ans51 = new Container_Info(new List<Concept_Info> {new Object_Info("Apple"), new Object_Info("Pear"), new Object_Info("Toilet paper")});
        answer[5][0].Add(ans51);

        return answer;
    }

    public List<List<List<Concept_Info>>> Shopping() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        Object_Info ans01 = new Object_Info("Restaurant");
        answer[0][1].Add(ans01);
    
        answer.Add(NewSubTask());
        AddNewObject(answer[1],3);
        Variable_Info ans11 = new Variable_Info("Integer", "2");
        answer[1][2].Add(ans11);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],3);
        Looping_Info ans21 = new Looping_Info(new Range_Info(1,10,1), new List<Concept_Info> { new Action_Info("Read Menu"), new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Food"), new Object_Info("Chosen Food"), new Logic_Info("=="))), new List<Concept_Info> {new Action_Info("Tell Waiter")})}, new Condition_Info(new Comparison_Info(new Object_Info("Food"), new Object_Info("Chosen Food"), new Logic_Info("=="))), null);
        answer[2][0].Add(ans21);
        answer[2][1].Add(ans21);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],3);
        Object_Info ans31 = new Object_Info("Supermarket");
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Container_Info ans41 = new Container_Info(new List<Concept_Info> {new Action_Info("Go Section A"),new Action_Info("Buy Things"),new Action_Info("Go Section C"),new Action_Info("Buy Things")});
        answer[4][0].Add(ans41);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],2);
        Container_Info ans51 = new Container_Info(new List<Concept_Info> {new Variable_Info("String", "Right"), new Variable_Info("String", "Walk 10"), new Variable_Info("String", "Left"),new Variable_Info("String", "Walk 5"), new Variable_Info("String", "Left"), new Variable_Info("String", "Walk 10")});
        answer[5][0].Add(ans51);

        return answer;
    }

    public List<List<List<Concept_Info>>> Detective_Tutorial() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Action_Info ans01 = new Action_Info("Mark is running");
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        Object_Info ans11 = new Object_Info("Mark's running speed");
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        Object_Info ans21 = new Object_Info("Joy's info");
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        answer[3].Add(NewObject());
        Comparison_Info ans31 = new Comparison_Info(new Object_Info("Mark's running speed"), new Variable_Info("Integer", "10"), new Logic_Info(">"));
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        answer[4].Add(NewObject());
        Comparison_Info ans311 = new Comparison_Info(new Object_Info("Mark's running speed"), new Variable_Info("Integer", "10"), new Logic_Info(">"));
        If_Statement_Info ans41 = new If_Statement_Info(new Condition_Info(ans311), new List<Concept_Info> {new Action_Info("Say HI to Joy")});
        answer[4][0].Add(ans41);

        return answer;
    }

    public List<List<List<Concept_Info>>> Cooking_Lesson() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        Object_Info ans01 = new Object_Info("Recipe");
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        Object_Info ans11 = new Object_Info("Flour");
        Object_Info ans12 = new Object_Info("Butter");
        Object_Info ans13 = new Object_Info("Sugar");
        Object_Info ans14 = new Object_Info("Leaveners");
        Object_Info ans15 = new Object_Info("Egg");
        Object_Info ans16 = new Object_Info("Vanilla");
        answer[1][1].Add(ans11);
        answer[1][1].Add(ans12);
        answer[1][1].Add(ans13);
        answer[1][1].Add(ans14);
        answer[1][1].Add(ans15);
        answer[1][1].Add(ans16);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],2);
        Container_Info ans21 = new Container_Info(new List<Concept_Info> {new Action_Info("Put"), new Object_Info("Sugar"), new Object_Info("Butter"), new Object_Info("Egg"), new Object_Info("Vanilla"), new Action_Info("End")});
        Container_Info ans22 = new Container_Info(new List<Concept_Info> {new Action_Info("Mix"), new Object_Info("Flour"), new Object_Info("Leaveners"), new Action_Info("End")});
        answer[2][0].Add(ans21);
        answer[2][1].Add(ans22);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],2);
        Container_Info ans31 = new Container_Info(new List<Concept_Info> {new Action_Info("Blend"), new Object_Info("flour mixture"), new Object_Info("butter mixture"), new Action_Info("End")});
        answer[3][1].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Container_Info ans41 = new Container_Info(new List<Concept_Info> {new Action_Info("Roll"), new Object_Info("final mixture"), new Action_Info("End")});
        answer[4][0].Add(ans41);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],2);
        Object_Info ans51 = new Object_Info("star cookie mold");
        Object_Info ans52 = new Object_Info("apple cookie mold");
        answer[5][0].Add(ans51);
        answer[5][0].Add(ans52);

        answer.Add(NewSubTask());
        AddNewObject(answer[6],2);
        Container_Info ans61 = new Container_Info(new List<Concept_Info> {new Action_Info("Put In"), new Object_Info("cookie"), new Object_Info("Place to put your cookie"), new Action_Info("End")});
        answer[6][1].Add(ans61);

        return answer;
    }

    public List<List<List<Concept_Info>>> Sport_Lesson() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        Object_Info ans01 = new Object_Info("Indoor Badminton Court Position");
        answer[0][0].Add(ans01);
        answer[0][1].Add(ans01);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        Object_Info ans11 = new Object_Info("badminton racket");
        Object_Info ans12 = new Object_Info("shuttle");
        answer[1][0].Add(ans11);
        answer[1][1].Add(ans11);
        answer[1][1].Add(ans12);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        If_Statement_Info if21 = new If_Statement_Info(new Condition_Info(new Action_Info("shuttle on the left side")), new List<Concept_Info> {new Action_Info("hit the shuttle on the left")});
        If_Statement_Info if22 = new If_Statement_Info(new Condition_Info(new Action_Info("shuttle on the right side")), new List<Concept_Info> {new Action_Info("hit the shuttle on the right")});
        Looping_Info ans21 = new Looping_Info(new Condition_Info(new Action_Info("shuttle not hit the ground")), new List<Concept_Info> {if21,if22}, null, null);
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],2);
        Object_Info ans31 = new Object_Info("Indoor Basketball Court Position");
        answer[3][0].Add(ans31);
        answer[3][1].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Object_Info ans41 = new Object_Info("Tom");
        Object_Info ans42 = new Object_Info("Herry");
        Object_Info ans43 = new Object_Info("Peter");
        Object_Info ans44 = new Object_Info("Joy");
        Object_Info ans45 = new Object_Info("Wilson");
        Object_Info ans46 = new Object_Info("James");
        answer[4][0].Add(ans41);
        answer[4][0].Add(ans42);
        answer[4][0].Add(ans43);
        answer[4][1].Add(ans44);
        answer[4][1].Add(ans45);
        answer[4][1].Add(ans46);

        answer.Add(NewSubTask());
        answer[5].Add(NewObject());
        If_Statement_Info if51 = new If_Statement_Info(new Condition_Info(new Action_Info("teammate want the ball")), new List<Concept_Info> {new Action_Info("pass the ball")});
        If_Statement_Info if52 = new If_Statement_Info(new Condition_Info(new Object_Info("time to shoot")), new List<Concept_Info> {new Action_Info("shoot")});
        Condition_Info con51 =  new Condition_Info(new Object_Info("either group reach 20 scores"));
        Looping_Info ans51 = new Looping_Info(new Condition_Info(new Object_Info("during the match")), new List<Concept_Info> {if51, if52}, con51, null);
        answer[5][0].Add(ans51);

        answer.Add(NewSubTask());
        AddNewObject(answer[6],3);
        Object_Info ans61 = new Object_Info("Entrance");
        answer[6][0].Add(ans61);
        answer[6][1].Add(ans61);
        answer[6][2].Add(ans61);

        return answer;
    }

    public List<List<List<Concept_Info>>> Tutorial5() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Object_Info ans01 = new Object_Info("Engine");
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        Object_Info ans11 = new Object_Info("Gear 2");
        Object_Info ans12 = new Object_Info("Gear 1");
        answer[1][0].Add(ans11);
        answer[1][1].Add(ans12);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        Condition_Info ans21 = new Condition_Info(new Comparison_Info(new Object_Info("Grape's value"),new Object_Info("Apple's value"),new Logic_Info(">")));
        answer[2][0].Add(ans21);
        return answer;
    }

    public List<List<List<Concept_Info>>> BigTask_Tutorial() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],5);
        If_Statement_Info ans01 = new If_Statement_Info(new Condition_Info(new Object_Info("want to order food")), new List<Concept_Info> {new Action_Info("Order")});
        If_Statement_Info ans02 = new If_Statement_Info(new Condition_Info(new Object_Info("finish the lunch")), new List<Concept_Info> {new Action_Info("Arrive Checkout Counter"),new Action_Info("Pay")});
        answer[0][0].Add(ans01);
        answer[0][0].Add(ans02);
        If_Statement_Info ans03 = new If_Statement_Info(new Condition_Info(new Object_Info("want to order food")), new List<Concept_Info> {new Action_Info("Arrive Table"),new Action_Info("Receive order")});
        If_Statement_Info ans04 = new If_Statement_Info(new Condition_Info(new Object_Info("food finish")), new List<Concept_Info> {new Action_Info("Arrive Pick Up Area"),new Action_Info("Pick up food"),new Action_Info("Arrive Table"),new Action_Info("Place down the food")});
        answer[0][1].Add(ans03);
        answer[0][1].Add(ans04);
        If_Statement_Info ans05 = new If_Statement_Info(new Condition_Info(new Object_Info("have new order")), new List<Concept_Info> {new Action_Info("Read order"), new Looping_Info(new Condition_Info(new Object_Info("food not ready")), new List<Concept_Info> {new Action_Info("Cook")}, new Condition_Info(new Object_Info("food ready")), null)});
        If_Statement_Info ans06 = new If_Statement_Info(new Condition_Info(new Object_Info("food finish")), new List<Concept_Info> {new Action_Info("Put the food in a plate"), new Action_Info("Arrive Pick Up Area"), new Action_Info("Place down the food and call")});
        answer[0][3].Add(ans05);
        answer[0][3].Add(ans06);
        If_Statement_Info ans07 = new If_Statement_Info(new Condition_Info(new Action_Info("Customer arrive")), new List<Concept_Info> {new Action_Info("Finish pay process")});
        answer[0][4].Add(ans07);
        return answer;
    }

    public List<List<List<Concept_Info>>> Treasure_Hunter() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],4);
        Object_Info ans01 = new Object_Info("Tom");
        Object_Info ans02 = new Object_Info("Herry");
        Object_Info ans03 = new Object_Info("Peter");
        answer[0][2].Add(ans01);
        answer[0][2].Add(ans02);
        answer[0][2].Add(ans03);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],1);
        Action_Info ans11 = new Action_Info("Arrive G/F");
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],1);
        Action_Info ans21 = new Action_Info("Arrive 1/F");
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],4);
        If_Statement_Info if31 = new If_Statement_Info(new Condition_Info(new Object_Info("obstacle's color is red")),new List<Concept_Info> {new Action_Info("Hop")});
        If_Statement_Info if32 = new If_Statement_Info(new Condition_Info(new Object_Info("obstacle's color is blue")),new List<Concept_Info> {new Action_Info("Jump")});
        Looping_Info ans31 = new Looping_Info(new Range_Info(1,10,1),new List<Concept_Info> {if31,if32},null,null);
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],1);
        Action_Info ans41 = new Action_Info("Stamp in 1/F");
        Action_Info ans42 = new Action_Info("Arrive 3/F");
        answer[4][0].Add(ans41);
        answer[4][0].Add(ans42);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],4);
        Looping_Info ans51 = new Looping_Info(new Condition_Info(new Object_Info("tangram not finish")),new List<Concept_Info> {new Action_Info("Play the tangram")},new Condition_Info(new Object_Info("tangram is finished")),null);
        answer[5][2].Add(ans51);

        answer.Add(NewSubTask());
        AddNewObject(answer[6],1);
        Action_Info ans61 = new Action_Info("Stamp in 3/F");
        Action_Info ans62 = new Action_Info("Arrive 2/F");
        answer[6][0].Add(ans61);
        answer[6][0].Add(ans62);

        answer.Add(NewSubTask());
        AddNewObject(answer[7],4);
        Action_Info ans71 = new Action_Info("Finish Mission 2");
        Action_Info ans72 = new Action_Info("Finish Mission 1");
        Action_Info ans73 = new Action_Info("Finish Mission 3");
        answer[7][0].Add(ans71);
        answer[7][1].Add(ans72);
        answer[7][2].Add(ans73);

        answer.Add(NewSubTask());
        AddNewObject(answer[8],2);
        Action_Info ans81 = new Action_Info("Ask where is the stamp");
        answer[8][1].Add(ans81);

        answer.Add(NewSubTask());
        AddNewObject(answer[9],1);
        Action_Info ans91 = new Action_Info("Arrive G/F");
        Action_Info ans92 = new Action_Info("Tell the teacher you finish the game");
        answer[9][0].Add(ans91);
        answer[9][0].Add(ans92);

        return answer;
    }

    public List<List<List<Concept_Info>>> Chaos() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        If_Statement_Info ans01 = new If_Statement_Info(new Condition_Info(new Object_Info("HI Instruction not created")),new List<Concept_Info> {new Action_Info("Create and Implement it")});
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        Action_Info ans11 = new Action_Info("Close Instruction");
        answer[1][0].Add(ans11);

        return answer;
    }

    public List<List<List<Concept_Info>>> WorkShop() {
        answer = NewAnswer();

        answer.Add(NewSubTask());

        answer[0].Add(NewObject());
        Container_Info ans01 = new Container_Info(new List<Concept_Info> {new Action_Info("Clean the room"),new Action_Info("Finish the setup of experiment"),new Action_Info("Invite him to go down"),new Action_Info("Test"),new Action_Info("Clean the room")});
        If_Statement_Info ans02 = new If_Statement_Info(new Condition_Info(new Object_Info("Finish Rehearsal")),new List<Concept_Info> {new Action_Info("Comfirm rundown")});
        answer[0][0].Add(ans01);
        answer[0][0].Add(ans02);

        answer[0].Add(NewObject());
        Container_Info ans03 = new Container_Info(new List<Concept_Info> {new Action_Info("Setup guild point 1"),new Action_Info("Setup guild point 3"),new Action_Info("Setup guild point 2"),new Action_Info("Setup guild point 4"),new Action_Info("Setup guild point 5"),new Action_Info("Setup guild point 1")});
        answer[0][1].Add(ans03);

        answer[0].Add(NewObject());
        Object_Info ans04 = new Object_Info("Camera");
        Object_Info ans05 = new Object_Info("Background Board");
        Object_Info ans06 = new Object_Info("Camera Stand");
        Object_Info ans07 = new Object_Info("MicroPhone");
        Object_Info ans08 = new Object_Info("Tables and Chairs");
        answer[0][2].Add(ans04);
        answer[0][2].Add(ans05);
        answer[0][2].Add(ans06);
        answer[0][2].Add(ans07);
        answer[0][2].Add(ans08);

        answer[0].Add(NewObject());
        Object_Info ans09 = new Object_Info("Display Board");
        Object_Info ans010 = new Object_Info("Display Board");
        Object_Info ans011 = new Object_Info("Poster");
        Object_Info ans012 = new Object_Info("LED Monitor");
        Container_Info ans013 = new Container_Info(new List<Concept_Info> {new Action_Info("Read the whole decoration guildline"),new Looping_Info(new Range_Info(1,4,1),new List<Concept_Info> {new Action_Info("Setup")},null,null)});
        answer[0][3].Add(ans09);
        answer[0][3].Add(ans010);
        answer[0][3].Add(ans011);
        answer[0][3].Add(ans012);
        answer[0][3].Add(ans013);

        answer[0].Add(NewObject());
        Action_Info ans014 = new Action_Info("Practice the greeter's skill");
        answer[0][4].Add(ans014);

        return answer;
    }

    public List<List<List<Concept_Info>>> RangeVar_Tutorial() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        RangeVar_Info ans01 = new RangeVar_Info(new Variable_Info("Integer","1"),new Variable_Info("Integer","5"),new Variable_Info("Integer","1"));
        answer[0][0].Add(ans01);

        answer.Add(NewSubTask());
        answer[1].Add(NewObject());
        RangeVar_Info ans11 = new RangeVar_Info(new Variable_Info("Integer","1"),new Variable_Info("Integer","10"),new Variable_Info("Float","0.5"));
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        answer[2].Add(NewObject());
        RangeVar_Info ans21 = new RangeVar_Info(new Variable_Info("Integer","1"),new Object_Info("Helper's height"),new Variable_Info("Integer","1"));
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        answer[3].Add(NewObject());
        RangeVar_Info ans31 = new RangeVar_Info(new Variable_Info("Integer","1"),new Object_Info("Number of apples"),new Variable_Info("Float","1.5"));
        answer[3][0].Add(ans31);

        return answer;
    }

    public List<List<List<Concept_Info>>> Librarian() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        AddNewObject(answer[0],2);
        Action_Info ans01 = new Action_Info("Arrive G/F");
        Action_Info ans02 = new Action_Info("Pick up books");
        Action_Info ans03 = new Action_Info("Arrive Library");
        Container_Info con01 = new Container_Info(new List<Concept_Info> {ans01,ans02,ans03});
        answer[0][0].Add(con01);

        answer.Add(NewSubTask());
        AddNewObject(answer[1],2);
        Looping_Info loop = new Looping_Info(new RangeVar_Info(new Variable_Info("Integer", "1"),new Object_Info("Number of unorganized book"),new Variable_Info("Integer", "1")), new List<Concept_Info> { new Action_Info("Check and put the book on the bookshelf")},null,null);
        Looping_Info ans11 = new Looping_Info(new RangeVar_Info(new Variable_Info("Integer", "1"),new Object_Info("Number of bookshelves"),new Variable_Info("Integer", "1")),new List<Concept_Info> {loop},null,null);
        answer[1][0].Add(ans11);

        answer.Add(NewSubTask());
        AddNewObject(answer[2],2);
        Looping_Info ans21 = new Looping_Info(new RangeVar_Info(new Variable_Info("Integer", "1"),new Object_Info("Number of books want to borrow"),new Variable_Info("Integer", "1")),new List<Concept_Info> {new Action_Info("Help borrow the book")},null,null);
        answer[2][0].Add(ans21);

        answer.Add(NewSubTask());
        AddNewObject(answer[3],2);
        Looping_Info ans31 = new Looping_Info(new RangeVar_Info(new Variable_Info("Integer", "1"),new Object_Info("Number of books want to return"),new Variable_Info("Integer", "1")),new List<Concept_Info> {new Action_Info("Help return the book")},null,null);
        answer[3][0].Add(ans31);

        answer.Add(NewSubTask());
        AddNewObject(answer[4],2);
        Looping_Info ans41 = new Looping_Info(new RangeVar_Info(new Variable_Info("Integer", "1"),new Object_Info("Number of borrowed book"),new Variable_Info("Integer", "1")),new List<Concept_Info> {new If_Statement_Info(new Condition_Info(new Comparison_Info(new Object_Info("Today's Date"),new Object_Info("Book Return Date"),new Logic_Info(">"))),new List<Concept_Info> {new Action_Info("Send letter")})},null,null);
        answer[4][0].Add(ans41);

        answer.Add(NewSubTask());
        AddNewObject(answer[5],2);
        Action_Info ans51 = new Action_Info("Call Student A leave");
        Action_Info ans52 = new Action_Info("Call Student B leave");
        Action_Info ans53 = new Action_Info("Close library");
        Action_Info ans54 = new Action_Info("Arrive classroom");
        Container_Info con51 = new Container_Info(new List<Concept_Info> {ans51,ans52,ans53,ans54});
        answer[5][0].Add(con51);

        return answer;
    }

    public List<List<List<Concept_Info>>> Camping() {
        answer = NewAnswer();
        answer.Add(NewSubTask());

        answer[0].Add(NewObject());
        Container_Info ans01 = new Container_Info(new List<Concept_Info> {new Action_Info("Arrive Camping Site"),new Action_Info("Place a Tarp"),new Action_Info("Lay out all the components of your tent"),new Action_Info("Lay your tent onto the tarp"),new Action_Info("Connect and insert tent poles"),new Action_Info("Stake the tent to the ground"),new Action_Info("Raise the tent")});
        answer[0][0].Add(ans01);

        answer[0].Add(NewObject());
        Container_Info ans11 = new Container_Info(new List<Concept_Info> {new Action_Info("Arrive Toilet"),new Action_Info("Arrive Camping Site"),new Action_Info("Pick up charcoal"),new Action_Info("Pick up lighter"),new Action_Info("Arrive Barbecue Site"),new Action_Info("Light a Fire")});
        answer[0][1].Add(ans11);

        answer[0].Add(NewObject());
        If_Statement_Info if21 = new If_Statement_Info(new Condition_Info(new Object_Info("Food arrive")),new List<Concept_Info> {new Looping_Info(new RangeVar_Info(new Variable_Info("Integer","1"),new Object_Info("Number of food"),new Variable_Info("Integer","1")),new List<Concept_Info> {new Action_Info("Unpack the food")},null,null)});
        Container_Info ans21 = new Container_Info(new List<Concept_Info> {new Action_Info("Arrive Registry Office"),new Action_Info("check-in"),new Action_Info("Arrive Barbecue Site"),new Action_Info("Clean the table"),if21});
        answer[0][2].Add(ans21);

        answer[0].Add(NewObject());
        answer[0][3].Add(ans01);

        answer[0].Add(NewObject());
        Container_Info ans41 = new Container_Info(new List<Concept_Info> {new Action_Info("Arrive Camping Site"),new Action_Info("Pick up barbecue fork"),new Action_Info("Pick up honey"),new Action_Info("Pick up food pack A"),new Action_Info("Pick up food pack C"),new Action_Info("Pick up food pack D"),new Action_Info("Arrive Barbecue Site")});
        answer[0][4].Add(ans41);

        return answer;
    }

    public List<List<List<Concept_Info>>> Answer_Sample() {
        answer = NewAnswer();

        answer.Add(NewSubTask());
        answer[0].Add(NewObject());
        Variable_Info ans01 = new Variable_Info("String", "Hello");
        answer[0][0].Add(ans01);

        return answer;
    }

    private List<List<List<Concept_Info>>> NewAnswer(){
        return new List<List<List<Concept_Info>>>();
    }

    private List<List<Concept_Info>> NewSubTask(){
        return new List<List<Concept_Info>>();
    }

    private List<Concept_Info> NewObject(){
        return new List<Concept_Info>();
    }

    void AddNewObject(List<List<Concept_Info>> l, int num) {
        for (int i = 0; i < num; i++) {
            l.Add(NewObject());
        }
    }

}
