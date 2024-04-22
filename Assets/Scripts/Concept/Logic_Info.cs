using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic_Info : Concept_Info
{
    //Concept Content
    public string operator_symbol;

    //Constructor for logic concept
    public Logic_Info(string op) {
        concept_name = "Logic";
        operator_symbol = op;
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
        //Checking the symbol are the same
        Logic_Info info = (Logic_Info)obj;
        return operator_symbol == info.operator_symbol;
    }
    public override int GetHashCode()
    {
        return operator_symbol.GetHashCode();
    }
}
