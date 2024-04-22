using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition_Info : Concept_Info
{
    //Concept Content
    public Concept_Info condition;

    ////Constructor for condition concept
    public Condition_Info(Concept_Info condition) {
        concept_name = "Condition";
        this.condition = condition;
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

        //Checking if condition are the same
        Condition_Info info = (Condition_Info)obj;
        return condition.Equals(info.condition);
    }

    public override int GetHashCode()
    {
        return condition.GetHashCode();
    }
}
