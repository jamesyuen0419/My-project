using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statement_Info : Concept_Info
{
    //Concept Content
    public Condition_Info condition;
    public List<Concept_Info> results;

    //Constructor for if statement concept
    public If_Statement_Info(Condition_Info condition, List<Concept_Info> results) {
        concept_name = "IfStatement";
        this.condition = condition;
        this.results = results;
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
        //Checking if number of step are the same
        If_Statement_Info info = (If_Statement_Info)obj;
        if (info.results.Count != results.Count) {
            return false;
        }
        //Checking if all the step in the if statement are the same and in order
        for (int i = 0; i < results.Count; i++) {
            if (!results[i].Equals(info.results[i])){
                return false;
            }
        }
        //Checking if condition are the same
        return condition.Equals(info.condition);
    }

    public override int GetHashCode()
    {
        return condition.GetHashCode() + results.GetHashCode();
    }
}
