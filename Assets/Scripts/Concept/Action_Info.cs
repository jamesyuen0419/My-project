using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Info : Concept_Info
{
    //Concept Content
    public string action;

    //Constructor for action concept
    public Action_Info(string action) {
        concept_name = "Action";
        this.action = action;
        nickname = action;
    }

    //Equal function for checking concept equal
    public override bool Equals(object obj)
    {
        //Empty check
        if (obj == null) {
            return false;
        }
        //Type check
        if (GetType() != obj.GetType()) {
            return false;
        }

        //Checking the stored action are the same
        Action_Info info = (Action_Info)obj;
        return action == info.action;
    }

    public override int GetHashCode()
    {
        return action.GetHashCode();
    }
}
