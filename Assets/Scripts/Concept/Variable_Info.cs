using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable_Info : Concept_Info
{
    //Concept Content
    public string variable_type;
    public string variable_name;

    //Constructor for variable concept
    public Variable_Info(string vt, string vn) {
        concept_name = "Variable";
        variable_name = vn;
        variable_type = vt;
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
        //Checking the specific case of no restriction on the value of the variable
        Variable_Info info = (Variable_Info)obj;
        if (variable_name == "Default") {
            return variable_type == info.variable_type;
        }
        //Checking the stored content are the same
        return variable_type == info.variable_type && variable_name == info.variable_name;
    }

    public override int GetHashCode()
    {
        return variable_type.GetHashCode() + variable_name.GetHashCode();
    }
}
