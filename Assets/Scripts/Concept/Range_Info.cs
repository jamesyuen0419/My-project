using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range_Info : Concept_Info
{
    //Concept Content
    public int start;
    public int end;
    public float interval;

    //Constructor for range concept
    public Range_Info(int s, int e, float inter) {
        concept_name = "Range";
        start = s;
        end = e;
        interval = inter;
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
        //Checking cross concept equal with range variable version
        if (obj.GetType() == typeof(RangeVar_Info)) {
            Variable_Info interval_test = null;
            //Checking float and integer version
            if (interval - Mathf.FloorToInt(interval) > 0) {
                interval_test = new Variable_Info("Float", interval.ToString());
            }
            else {
                interval_test = new Variable_Info("Integer", interval.ToString());
            }
            RangeVar_Info test = new RangeVar_Info(new Variable_Info("Integer", start.ToString()),new Variable_Info("Integer", end.ToString()), interval_test);
            if (test.Equals(obj)) {
                return true;
            }
            else {
                return false;
            }
        }
        //Checking the stored content are the same
        Range_Info info = (Range_Info)obj;
        return start == info.start && end == info.end && interval == info.interval;
    }

    public override int GetHashCode()
    {
        return start.GetHashCode() * 35 + end.GetHashCode() * 17 + interval.GetHashCode();
    }
}
