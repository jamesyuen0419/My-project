using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping_Info : Concept_Info
{
    //Concept Content
    public Concept_Info condition;
    public List<Concept_Info> actions;
    public Condition_Info break_condition;
    public Condition_Info continue_condition;

    //Constructor for looping concept
    public Looping_Info(Concept_Info condition, List<Concept_Info> actions, Condition_Info breaks, Condition_Info continues) {
        concept_name = "Looping";
        this.condition = condition;
        this.actions = actions;
        break_condition = breaks;
        continue_condition = continues;
    }

    //Equal function for checking concept equal
    public override bool Equals(object obj)
    {
        // If error existing in comparison, they are not equal
        try {
            //Empty check
            if (obj == null) {
                return false;
            }
            //Type check
            if (GetType() != obj.GetType()) {
                return false;
            }
            //Condition type check
            if (condition.GetType() != ((Looping_Info) obj).condition.GetType()) {
                return false;
            }

            Looping_Info info = (Looping_Info)obj;
            //Checking all step are the same
            for (int i = 0; i < actions.Count; i++) {
                if (!actions[i].Equals(info.actions[i])){
                    return false;
                }
            }

            //Checking whether the break and continue conditions are the same
            bool test1 = false;
            bool test2 = false;
            if (break_condition != null) {
                test1 = break_condition.Equals(info.break_condition);
            }
            else {
                test1 = info.break_condition == null;
            }
            if (continue_condition != null) {
                test2 = continue_condition.Equals(info.continue_condition);
            }
            else {
                test2 = info.continue_condition == null;
            }
            //Checking the condition are the same as well
            return condition.Equals(info.condition) && test1 && test2;
        } catch (Exception) {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return condition.GetHashCode() + break_condition.GetHashCode() + continue_condition.GetHashCode() + actions.GetHashCode();
    }
}
