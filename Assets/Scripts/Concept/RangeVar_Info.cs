using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeVar_Info : Concept_Info
{
    //Concept Content
    public Concept_Info start;
    public Concept_Info end;
    public Concept_Info interval;

    //Constructor for range variable version concept
    public RangeVar_Info(Concept_Info s, Concept_Info e, Concept_Info inter) {
        concept_name = "Range_Var";
        start = s;
        end = e;
        interval = inter;
    }

    //Equal function for checking concept equal. As we would like the user learning the mixture of variable and range, user not allow to use range concept to be the submission 
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
        //Checking the stored content are the same
        RangeVar_Info info = (RangeVar_Info)obj;
        return start.Equals(info.start) && end.Equals(info.end) && interval.Equals(info.interval);
    }

    public override int GetHashCode()
    {
        return start.GetHashCode() * 35 + end.GetHashCode() * 17 + interval.GetHashCode();
    }
}
