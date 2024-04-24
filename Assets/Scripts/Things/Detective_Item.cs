using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detective_Item
{
    //Storage of all task detective item list
    public List<(int, string, string, List<Combined_Card_Info>)> Detective_Tutorial() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {
            (0, "Mark", "Mark is running along the street",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Mark is running", "Action", new Action_Info("Mark is running")),
                    new Combined_Card_Info("Mark's running speed", "Object", new Object_Info("Mark's running speed"))
                }
            ),
            (0, "Joy", "Joy is walking along the street",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Joy is walking", "Action", new Action_Info("Joy is walking")),
                    new Combined_Card_Info("Joy's info", "Object", new Object_Info("Joy's info")),
                    new Combined_Card_Info("Say HI to Joy", "Action", new Action_Info("Say HI to Joy")),
                }
            ),
            (1, "Box", "Here has nothing",
                new List<Combined_Card_Info> {}
            )
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Task10() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Cooking_Lesson() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        
            (0, "Teacher", "Teacher is standing in front of the table",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Recipe", "Object", new Object_Info("Recipe")),
                }
            ),
            (1, "Ingredient Box 1", "This box is full of ingredients",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Flour", "Object", new Object_Info("Flour")),
                    new Combined_Card_Info("Butter", "Object", new Object_Info("Butter")),
                    new Combined_Card_Info("Apple", "Object", new Object_Info("Apple")),
                    new Combined_Card_Info("Sugar", "Object", new Object_Info("Sugar"))
                }
            ),
            (1, "Ingredient Box 2", "This box is full of ingredients",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Milk", "Object", new Object_Info("Milk")),
                    new Combined_Card_Info("Leaveners", "Object", new Object_Info("Leaveners")),
                    new Combined_Card_Info("Egg", "Object", new Object_Info("Egg")),
                    new Combined_Card_Info("Vanilla", "Object", new Object_Info("Vanilla"))
                }
            ),
            (1, "Tool Box", "This box is full of tools",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("star cookie mold", "Object", new Object_Info("star cookie mold")),
                    new Combined_Card_Info("orange cookie mold", "Object", new Object_Info("orange cookie mold")),
                    new Combined_Card_Info("apple cookie mold", "Object", new Object_Info("apple cookie mold")),
                    new Combined_Card_Info("moon cookie mold", "Object", new Object_Info("moon cookie mold"))
                }
            ),
            (1, "Oven", "A normal oven",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Place to put your cookie", "Object", new Object_Info("Place to put your cookie"))
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Sport_Lesson() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        
            (2, "Indoor Badminton Court", "This indoor badminton court look great!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Position", "Object", new Object_Info("Indoor Badminton Court Position")),
                    new Combined_Card_Info("Badminton Racket", "Object", new Object_Info("badminton racket")),
                    new Combined_Card_Info("Shuttle", "Object", new Object_Info("shuttle")),
                    new Combined_Card_Info("Situation - shuttle not hit the ground", "Condition", new Condition_Info(new Action_Info("shuttle not hit the ground"))),
                    new Combined_Card_Info("Situation - shuttle on the left side", "Condition", new Condition_Info(new Action_Info("shuttle on the left side"))),
                    new Combined_Card_Info("Situation - shuttle on the right side", "Condition", new Condition_Info(new Action_Info("shuttle on the right side"))),
                    new Combined_Card_Info("Action - hit the shuttle on the left", "Action", new Action_Info("hit the shuttle on the left")),
                    new Combined_Card_Info("Action - hit the shuttle on the right", "Action", new Action_Info("hit the shuttle on the right")),
                }
            ),
            (2, "Indoor Backetball Court", "This indoor basketball court look awesome!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Position", "Object", new Object_Info("Indoor Basketball Court Position")),
                    new Combined_Card_Info("Joy", "Object", new Object_Info("Joy")),
                    new Combined_Card_Info("Peter", "Object", new Object_Info("Peter")),
                    new Combined_Card_Info("Wilson", "Object", new Object_Info("Wilson")),
                    new Combined_Card_Info("James", "Object", new Object_Info("James")),
                    new Combined_Card_Info("Situation - teammate want the ball", "Condition", new Condition_Info(new Action_Info("teammate want the ball"))),
                    new Combined_Card_Info("Situation - time to shoot", "Condition", new Condition_Info(new Object_Info("time to shoot"))),
                    new Combined_Card_Info("Situation - during the match", "Condition", new Condition_Info(new Object_Info("during the match"))),
                    new Combined_Card_Info("Situation - either group reach 20 scores", "Condition", new Condition_Info(new Object_Info("either group reach 20 scores"))),
                    new Combined_Card_Info("Action - pass the ball", "Action", new Action_Info("pass the ball")),
                    new Combined_Card_Info("Action - shoot", "Action", new Action_Info("shoot")),
                }
            ),
            (2, "Entrance", "This is the entrance of the stadium!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Position", "Object", new Object_Info("Entrance")),
                }
            ),
            (2, "Gym Room", "This is the gym room, work out!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Position", "Object", new Object_Info("Gym Room")),
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Task13() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> BigTask_Tutorial() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        
            (2, "Pick Up Area", "Waiter can pick up the food in this area.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Pick Up Area", "Action", new Action_Info("Arrive Pick Up Area")),
                    new Combined_Card_Info("Place down the food and call", "Action", new Action_Info("Place down the food and call")),
                    new Combined_Card_Info("State - food finish", "Condition", new Condition_Info(new Object_Info("food finish"))),
                    new Combined_Card_Info("Pick up food", "Action", new Action_Info("Pick up food"))
                }
            ),
            (2, "Kitchen", "Chefs are waiting here to prepare your food!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Kitchen", "Action", new Action_Info("Arrive Kitchen")),
                    new Combined_Card_Info("Put the food in a plate", "Action", new Action_Info("Put the food in a plate")),
                    new Combined_Card_Info("State - have new order", "Condition", new Condition_Info(new Object_Info("have new order"))),
                    new Combined_Card_Info("State - food ready", "Condition", new Condition_Info(new Object_Info("food ready"))),
                    new Combined_Card_Info("State - food not ready", "Condition", new Condition_Info(new Object_Info("food not ready"))),
                }
            ),
            (2, "Checkout Counter", "You can pay your money here.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Checkout Counter", "Action", new Action_Info("Arrive Checkout Counter")),
                    new Combined_Card_Info("State - Customer arrive", "Condition", new Condition_Info(new Action_Info("Customer arrive")))
                }
            ),
            (2, "Table", "Customer is waiting here.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Table", "Action", new Action_Info("Arrive Table")),
                    new Combined_Card_Info("Place down the food", "Action", new Action_Info("Place down the food")),
                    new Combined_Card_Info("State - want to order food", "Condition", new Condition_Info(new Object_Info("want to order food"))),
                    new Combined_Card_Info("State - finish the lunch", "Condition", new Condition_Info(new Object_Info("finish the lunch"))),
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Treasure_Hunter() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        
            (2, "G/F", "This is the ground floor.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive G/F", "Action", new Action_Info("Arrive G/F")),
                    new Combined_Card_Info("Tell the teacher you finish the game", "Action", new Action_Info("Tell the teacher you finish the game")),
                }
            ),
            (2, "1/F", "This is the first floor.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Stamp in 1/F", "Action", new Action_Info("Stamp in 1/F")),
                    new Combined_Card_Info("Arrive 1/F", "Action", new Action_Info("Arrive 1/F")),
                    new Combined_Card_Info("Situation - obstacle's color is red", "Condition", new Condition_Info(new Object_Info("obstacle's color is red"))),
                    new Combined_Card_Info("Situation - obstacle's color is blue", "Condition", new Condition_Info(new Object_Info("obstacle's color is blue"))),
                }
            ),
            (2, "2/F", "This is the second floor. Here have 3 sub missions. Mission 1 is related to basketball. Mission 2 is related to Music. Mission 3 is related to Science.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Ask where is the stamp", "Action", new Action_Info("Ask where is the stamp")),
                    new Combined_Card_Info("Arrive 2/F", "Action", new Action_Info("Arrive 2/F")),
                    new Combined_Card_Info("Finish Mission 1", "Action", new Action_Info("Finish Mission 1")),
                    new Combined_Card_Info("Finish Mission 2", "Action", new Action_Info("Finish Mission 2")),
                    new Combined_Card_Info("Finish Mission 3", "Action", new Action_Info("Finish Mission 3")),
                }
            ),
            (2, "3/F", "This is the third floor.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Stamp in 3/F", "Action", new Action_Info("Stamp in 3/F")),
                    new Combined_Card_Info("Arrive 3/F", "Action", new Action_Info("Arrive 3/F")),
                    new Combined_Card_Info("Situation - tangram not finish", "Condition", new Condition_Info(new Object_Info("tangram not finish"))),
                    new Combined_Card_Info("Situation - tangram is finished", "Condition", new Condition_Info(new Object_Info("tangram is finished"))),
                    new Combined_Card_Info("Play the tangram", "Action", new Action_Info("Play the tangram")),
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Chaos() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {       
            (1, "HI Instruction", "Here consist the HI Instruction related stuffs.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Implement the broken version", "Action", new Action_Info("Implement the broken version")),
                    new Combined_Card_Info("Create and Implement it", "Action", new Action_Info("Create and Implement it")),
                    new Combined_Card_Info("Situation - HI Instruction not created", "Condition", new Condition_Info(new Object_Info("HI Instruction not created"))),
                }
            ),
            (1, "Bye Instruction", "Bye Instruction is already outdated. Please use Close Instruction instead.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Implement Bye Instruction", "Action", new Action_Info("Bye Instruction")),
                    new Combined_Card_Info("Implement Close Instruction", "Action", new Action_Info("Close Instruction")),
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> WorkShop() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        
            (2, "Entrance", "Entrance of the school.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Practice the greeter's skill", "Action", new Action_Info("Practice the greeter's skill")),
                }
            ),
            (2, "Biology Room", "Teacher will organize a experiment about element of food.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Finish the setup of experiment", "Action", new Action_Info("Finish the setup of experiment")),
                    new Combined_Card_Info("Clean the room", "Action", new Action_Info("Clean the room")),
                    new Combined_Card_Info("Test", "Action", new Action_Info("Test")),
                }
            ),
            (2, "G/F", "There should be some decoration in the ground floor.",
                new List<Combined_Card_Info> {
                }
            ),
            (2, "1/F", "Ooh, the guildline route is missing in this floor! The Route should be 1 -> 3 -> 2 -> 4 -> 5 -> 1",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Setup guild point 1", "Action", new Action_Info("Setup guild point 1")),
                    new Combined_Card_Info("Setup guild point 2", "Action", new Action_Info("Setup guild point 2")),
                    new Combined_Card_Info("Setup guild point 3", "Action", new Action_Info("Setup guild point 3")),
                    new Combined_Card_Info("Setup guild point 4", "Action", new Action_Info("Setup guild point 4")),
                    new Combined_Card_Info("Setup guild point 5", "Action", new Action_Info("Setup guild point 5")),
                    new Combined_Card_Info("Setup guild point 6", "Action", new Action_Info("Setup guild point 6"))
                }
            ),
            (2, "2/F", "Everything is good, but maybe we can add a new event on this floor as there is a big empty space!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Setup the new event", "Action", new Action_Info("Setup the new event")),
                }
            ),
            (1, "Decoration Box", "This box contains different type of decoration materials. The decoration guildline consist of 5 steps which is start from step 1.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Display Board", "Object", new Object_Info("Display Board")),
                    new Combined_Card_Info("Poster", "Object", new Object_Info("Poster")),
                    new Combined_Card_Info("LED Monitor", "Object", new Object_Info("LED Monitor")),
                }
            ),
            (0, "Biology Teacher", "This teacher are going to perform a experiment on the workshop day!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Invite him to go down for rehearsal", "Action", new Action_Info("Invite him to go down")),
                    new Combined_Card_Info("Situation - Finish Rehearsal", "Condition", new Condition_Info(new Object_Info("Finish Rehearsal"))),
                    new Combined_Card_Info("Comfirm rundown", "Action", new Action_Info("Comfirm rundown")),
                }
            ),
            (1, "Event Material", "Material for photo event",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Camera", "Object", new Object_Info("Camera")),
                    new Combined_Card_Info("Background Board", "Object", new Object_Info("Background Board")),
                    new Combined_Card_Info("Camera Stand", "Object", new Object_Info("Camera Stand")),
                }
            ),
            (1, "Event Material", "Material for teaching event",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Teaching material", "Object", new Object_Info("Teaching material")),
                    new Combined_Card_Info("MicroPhone", "Object", new Object_Info("MicroPhone")),
                    new Combined_Card_Info("Tables and Chairs", "Object", new Object_Info("Tables and Chairs")),
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> RangeVar_Tutorial() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Librarian() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        { 
            (2, "G/F", "Some books arrives.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive G/F", "Action", new Action_Info("Arrive G/F")),
                    new Combined_Card_Info("Pick up books", "Action", new Action_Info("Pick up books"))
                }
            ),
            (2, "Library", "This is the place Tom need to stay for every breaks in Monday and Friday.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Library", "Action", new Action_Info("Arrive Library")),
                    new Combined_Card_Info("Number of bookshelves", "Object", new Object_Info("Number of bookshelves")),
                    new Combined_Card_Info("Number of unorganized book", "Object", new Object_Info("Number of unorganized book")),
                    new Combined_Card_Info("Close library", "Action", new Action_Info("Close library")),
                    new Combined_Card_Info("Number of borrowed book", "Object", new Object_Info("Number of borrowed book")),
                    new Combined_Card_Info("Book Return Date", "Object", new Object_Info("Book Return Date")),
                }
            ),
            (2, "Classroom", "Tom will have lesson in the classroom",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive classroom", "Action", new Action_Info("Arrive classroom"))
                }
            ),
            (0, "Student", "This student loving reading book and want to borrow more!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Number of books want to borrow", "Object", new Object_Info("Number of books want to borrow")),
                    new Combined_Card_Info("Number of books want to return", "Object", new Object_Info("Number of books want to return")),
                }
            ),
            (0, "Student A", "Shh! This student is reading book!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Call Student A leave", "Action", new Action_Info("Call Student A leave"))
                }
            ),
            (0, "Student B", "Shh! This student is reading book!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Call Student B leave", "Action", new Action_Info("Call Student B leave"))
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Camping() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        
            (2, "Barbecue Site", "Let go barbecue!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Barbecue Site", "Action", new Action_Info("Arrive Barbecue Site")),
                    new Combined_Card_Info("Situation - Food arrive", "Condition", new Condition_Info(new Object_Info("Food arrive"))),
                    new Combined_Card_Info("Situation - Food not arrive", "Condition", new Condition_Info(new Object_Info("Food not arrive"))),
                    new Combined_Card_Info("Number of food pack", "Object", new Object_Info("Number of food")),
                    new Combined_Card_Info("Light a Fire", "Action", new Action_Info("Light a Fire")),
                    new Combined_Card_Info("Clean the table", "Action", new Action_Info("Clean the table")),
                    new Combined_Card_Info("Unpack the food", "Action", new Action_Info("Unpack the food"))
                }
            ),
            (2, "Camping Site", "You can set up your camp here. All the backpacks are put here.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Camping Site", "Action", new Action_Info("Arrive Camping Site")),
                    new Combined_Card_Info("Raise the tent", "Action", new Action_Info("Raise the tent")),
                    new Combined_Card_Info("Lay out all the components of your tent", "Action", new Action_Info("Lay out all the components of your tent")),
                    new Combined_Card_Info("Connect and insert tent poles", "Action", new Action_Info("Connect and insert tent poles")),
                    new Combined_Card_Info("Stake the tent to the ground", "Action", new Action_Info("Stake the tent to the ground")),
                    new Combined_Card_Info("Place a Tarp", "Action", new Action_Info("Place a Tarp")),
                    new Combined_Card_Info("Lay your tent onto the tarp", "Action", new Action_Info("Lay your tent onto the tarp")),
                }
            ),
            (2, "Registry Office", "You need to check-in when you arrive.",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Registry Office", "Action", new Action_Info("Arrive Registry Office")),
                    new Combined_Card_Info("check-in", "Action", new Action_Info("check-in"))
                }
            ),
            (2, "Toilet", "This is a necessary place!",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Arrive Toilet", "Action", new Action_Info("Arrive Toilet")),
                }
            ),
            (1, "Backpack A", "There are number of things inside the Backpack",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Pick up charcoal", "Action", new Action_Info("Pick up charcoal")),
                    new Combined_Card_Info("Pick up lighter", "Action", new Action_Info("Pick up lighter"))
                }
            ),
            (1, "Backpack B", "There are number of things inside the Backpack",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Pick up honey", "Action", new Action_Info("Pick up honey")),
                    new Combined_Card_Info("Pick up pan", "Action", new Action_Info("Pick up pan")),
                    new Combined_Card_Info("Pick up barbecue fork", "Action", new Action_Info("Pick up barbecue fork")),
                    new Combined_Card_Info("Pick up camp stove", "Action", new Action_Info("Pick up camp stove")),
                }
            ),
            (1, "Backpack C", "There are number of things inside the Backpack",
                new List<Combined_Card_Info> {
                    new Combined_Card_Info("Pick up food pack A", "Action", new Action_Info("Pick up food pack A")),
                    new Combined_Card_Info("Pick up food pack B", "Action", new Action_Info("Pick up food pack B")),
                    new Combined_Card_Info("Pick up food pack C", "Action", new Action_Info("Pick up food pack C")),
                    new Combined_Card_Info("Pick up food pack D", "Action", new Action_Info("Pick up food pack D")),
                    new Combined_Card_Info("Pick up food pack E", "Action", new Action_Info("Pick up food pack E")),
                }
            ),
        };
        
        return cards;
    }

    public List<(int, string, string, List<Combined_Card_Info>)> Task() {
        List<(int, string, string, List<Combined_Card_Info>)> cards = new List<(int, string, string, List<Combined_Card_Info>)>
        {        };
        
        return cards;
    }
}
