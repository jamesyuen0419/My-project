using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using Unity.VisualScripting;
using System.IO;

public class DataBase : MonoBehaviour
{
    private string conceptDB = "URI=file:Concept.db";  //file path to conceptDB
    private string playerDB = "URI=file:Player.db";  //file path to playerDB

    //Checking if database is downloaded in the product file
    void Start()
    {
        try {
            GetConceptInfo(0, 1);
        }
        catch (Exception) {
            CreateDB();
            CreateSearchConceptDB();
            AddDefaultDB();
            AddSearchConceptDB();
        }

        try {
            GetPlayerSetting();
        }
        catch (Exception) {
            CreateplayerDB();
            CreateplayertimeDB();
            AddPlayerDB();
        }
    }

    //Create the concept table
    private void CreateDB()
    {
        using(var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "CREATE TABLE IF NOT EXISTS concept (concept_group Int NOT NULL, concept_group_id Int NOT NULL, name TEXT NOT NULL, description TEXT NOT NULL);";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Create the search concept table
    private void CreateSearchConceptDB()
    {
        using(var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "CREATE TABLE IF NOT EXISTS searchConcept (concept_group Int NOT NULL, concept_group_id Int NOT NULL, name TEXT NOT NULL);";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Create the player table
    private void CreateplayerDB()
    {
        using (var connection = new SqliteConnection(playerDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "CREATE TABLE IF NOT EXISTS player (levelCompleted INT NOT NULL, audioVol FLOAT NOT NULL);";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Create the player time table
    private void CreateplayertimeDB()
    {
        using (var connection = new SqliteConnection(playerDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "CREATE TABLE IF NOT EXISTS playertime (time TEXT);";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }

        using (var connection = new SqliteConnection(playerDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "INSERT INTO playertime (time) VALUES ('null');";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Save the player time for enter the task 0 for the first time
    public void SetPlayerTime(DateTime time) {
        string timeString = time.ToString("yyyy-MM-dd HH:mm:ss");

        using (var connection = new SqliteConnection(playerDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "UPDATE playertime SET time = '" + timeString +  "';";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Retrieve the player time data
    public string GetPlayerTime() {
        string timeString = "";

        using (var connection = new SqliteConnection(playerDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "SELECT time FROM playertime;";
                using (IDataReader reader = com.ExecuteReader())
                {
                    reader.Read();
                    timeString = reader.GetString(0);
                    reader.Close();
                }
            }

            connection.Close();
        }

        return timeString;
    }

    //Add date to the concept table
    private void AddDefaultDB()
    {
        using (var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "INSERT INTO concept (concept_group, concept_group_id, name, description) " +
                                  "VALUES " +
                                  "(0,0,'Looping','Looping Concept represents iteration and repeating under a condition. This concept can be divided into four parts.')," +
                                  "(0,1,'Looping Condition','Designing when to stop the recursive work(Condition) or the number of iteration(Range).')," +
                                  "(0,2,'Actions','Contains all the things that you want to do repeatedly in the loop.')," +
                                  "(0,3,'Continue Condition','Condition to skip the current iteration without finishing all the things in the actions part.')," +
                                  "(0,4,'Break Condition','Condition to stop the iteration when a specific condition is fulfilled.')," +
                                  "(1,0,'Condition','This concept is to test whether a requirement is fulfilled or not. To understand this concept, you may also need to study logic and comparison before modifying Condition concept.')," +
                                  "(1,1,'IfElse','This concept makes use of Condition concept. If a condition is fulfilled, things A will be done. Otherwise, things B will be done.\nIn the task, you can use two If statements to perform IfElse.')," +
                                  "(2,0,'Logic','This concept includes a lot of different operators to compare different things, like object and condition.')," +
                                  "(2,1,'And','And operator is to check whether two conditions are true or not.\nHere is the And table:\nTrue True = True\nTrue False = False\nFalse True = False\nFalse False = False')," +
                                  "(2,2,'Or','Or operator is to check whether two conditions contain at least one True condition.\nHere is the Or table:\nTrue True = True\nTrue False = True\nFalse True = True\nFalse False = False')," +
                                  "(2,3,'True','True means this condition is fullfilled or we can say it is correct!\n\nFor example, 3 < 10 -> True!')," +
                                  "(2,4,'False','False means this condition is not fullfilled or we can say it is wrong!\n\nFor example, 3 > 10 -> False!')," +
                                  "(2,5,'Not','Not operator is to reverse the result of a condition.\nHere is the Not table:\nNot True = False\nNot False = True')," +
                                  "(3,0,'Comparison','This concept has always been used to form a condition. You can use the Comparision concept to compare values.\nHere are some operators for comparison:\n> : Larger than\n>= : Larger than or equal to\n< : smaller than\n <= : smaller than or equal to\n== : equal to\n!= : not equal to')," +
                                  "(4,0,'Variable','Variable is like a box that contain two important things:\nValue - the thing that you put inside the box\nType - a label on the bag to restrict what to put inside the box.')," +
                                  "(4,1,'DataType','There are lots of different types of variables. In this game, we introduce a number of types: Character: It can store a single character. For example, letter, digital symbol and special symbol.\nString: A list of character or you can call word\nInteger: mathematical integer\nFloat: floating point number\nBool: Boolean value True and False.')," +
                                  "(4,2,'Initization','Initization means the step you take to create a variable, which you will handle in Variable concept modification.')," +
                                  "(5,0,'Container','Container can be thought of as a big bag that can contain multiple items. Some common examples are List and Dictionary.')," +
                                  "(5,3,'Index','Index means the position of an item in the container. This also means the order of an item in a container affects its correctness!')," +
                                  "(5,4,'Length','The total number of items in the container.')," +
                                  "(5,5,'Append','The action that you take is to add an item to the container.')," +
                                  "(5,6,'Remove','The action that you take to remove an item from the container.')," +
                                  "(6,0,'Action','This concept includes all the actions from the tasks that may be useful in your concept combination.')," +
                                  "(7,0,'Object','This concept includes all the objects from the tasks that may be useful in your concept combination.');" ;                                 
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Add date to the search concept table
    private void AddSearchConceptDB()
    {
        using (var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "INSERT INTO searchConcept (concept_group, concept_group_id, name) " +
                                  "VALUES " +
                                  "(0,0,'Looping')," +
                                  "(0,1,'Looping')," +
                                  "(1,0,'Condition')," +
                                  "(1,1,'Condition')," +
                                  "(1,2,'Range')," +
                                  "(1,3,'Range_Var')," +
                                  "(2,0,'Logic')," +
                                  "(2,1,'True')," +
                                  "(2,2,'False')," +
                                  "(2,3,'And')," +
                                  "(2,4,'Or')," +
                                  "(2,5,'Larger')," +
                                  "(2,6,'Smaller')," +
                                  "(2,7,'Equal')," +
                                  "(2,8,'Not Equal')," +
                                  "(3,0,'Comparison')," +
                                  "(3,1,'Comparison')," +
                                  "(4,0,'IfElse')," +
                                  "(4,1,'IfStatement')," +
                                  "(5,0,'Variable')," +
                                  "(5,1,'Variable')," +
                                  "(6,0,'Container')," +
                                  "(6,1,'Container')," +
                                  "(7,0,'Action')," +
                                  "(8,0,'Object');";                             
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Add date to the player table
    private void AddPlayerDB()
    {
        using (var connection = new SqliteConnection(playerDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "INSERT INTO player (levelCompleted, audioVol) " +
                                  "VALUES " +
                                  "(0,0.5);" ;                                
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    //Clear the table
    private void DelateTable(int num) {
        if (num == 1) {
            using(var connection = new SqliteConnection(conceptDB))
            {
                connection.Open();

                using (var com = connection.CreateCommand())
                {
                    com.CommandText = "DELETE FROM concept;";
                    com.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        else if (num == 2) {
            using(var connection = new SqliteConnection(conceptDB))
            {
                connection.Open();

                using (var com = connection.CreateCommand())
                {
                    com.CommandText = "DELETE FROM searchConcept;";
                    com.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        else {
            using(var connection = new SqliteConnection(playerDB))
            {
                connection.Open();

                using (var com = connection.CreateCommand())
                {
                    com.CommandText = "DELETE FROM player;";
                    com.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
 
    }

    //Get the description of a concept part
    public Dictionary<string, string> GetConceptInfo(int number, int id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();
        using (var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "SELECT name, description FROM concept " +
                                  "WHERE concept_group_id == " + id + " AND " +
                                  "concept_group == " + number + " ;";

                using (IDataReader reader = com.ExecuteReader())
                {
                    reader.Read();
                    result.Add("name", reader.GetString(0));
                    result.Add("description", reader.GetString(1));
                    reader.Close();
                }
            }

            connection.Close();
        }

        return result;
    }

    //Retrieve all the name of the concept
    public List<string> GetConceptNames()
    {
        List<string> concept_names = new List<string>();

        using (var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "SELECT name FROM concept " +
                                  "WHERE concept_group_id == 0 ;";

                using (IDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        concept_names.Add(reader.GetString(0));
                    }
                }
            }

            connection.Close();
        }

        return concept_names;
    }

    //Retrieve all the concept parts
    public List<string> GetConceptInnerNames(int num)
    {
        List<string> concept_names = new List<string>();

        using (var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "SELECT name FROM concept " +
                                  "WHERE concept_group == " + num + " ;";

                using (IDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        concept_names.Add(reader.GetString(0));
                    }
                }
            }

            connection.Close();
        }

        return concept_names;
    }

    //Retrieve all the concept blocks for certain concept
    public List<string> GetSearchConceptList(int number) {

        List<string> result = new List<string>();

        using (var connection = new SqliteConnection(conceptDB))
        {
            connection.Open();

            using (var com = connection.CreateCommand())
            {
                com.CommandText = "SELECT name FROM searchConcept " +
                                  "WHERE concept_group_id != 0 AND " +
                                  "concept_group == '" + number + "';";

                using (IDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }
            connection.Close();
        }
        return result;
    }

    //Update the player database
    public void UpdatePlayerSetting(int tasks, float audioVol) {
        
        using (var connection = new SqliteConnection(playerDB)) {
            connection.Open();

            using (var com = connection.CreateCommand()) {
                com.CommandText = "UPDATE player SET levelCompleted = " + tasks + ", audioVol = " + audioVol + ";";
                com.ExecuteNonQuery();
            }

            connection.Close();
        }
        
    }

    //Retrieve player data
    public (int, float) GetPlayerSetting() {
        int task_com = 0;
        float audioVol = 0;
        using (var connection = new SqliteConnection(playerDB)) {
            connection.Open();

            using (var com = connection.CreateCommand()) {
                com.CommandText = "SELECT * FROM player ;";

                using (IDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        task_com = (int) reader["levelCompleted"];
                        audioVol = reader["audioVol"].ConvertTo<float>();
                    }
                }
            }

            connection.Close();
        }
        
        return (task_com, audioVol);
    }
}
