using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparison_Info : Concept_Info
{
    //Concept Content
    public Concept_Info objA;
    public Concept_Info objB;
    public Logic_Info sym;

    //Constructor for comparison concept
    public Comparison_Info(Concept_Info a, Concept_Info b, Logic_Info op) {
        concept_name = "Comparison";
        objA = a;
        objB = b;
        sym = op;
    }

    ////Equal function for checking concept equal
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

        //Checking whether there some wrap cases like a = b and b = a or a > b and b < a
        Comparison_Info info = (Comparison_Info)obj;
        if (sym.operator_symbol == "==" || sym.operator_symbol == "!=" || sym.operator_symbol == "&" || sym.operator_symbol == "|") {
            if (sym.Equals(info.sym)) {
                if (objA.Equals(info.objB) && objB.Equals(info.objA)) {
                    return true;
                }
            }
            else {
                return false;
            }
        }
        else if (sym.operator_symbol == ">") {
            if (objA.Equals(info.objB) && objB.Equals(info.objA) && info.sym.operator_symbol == "<") {
                return true;
            }
        }
        else if (sym.operator_symbol == "<") {
            if (objA.Equals(info.objB) && objB.Equals(info.objA) && info.sym.operator_symbol == ">") {
                return true;
            }
        }

        //Checking the concept are identical
        return objA.Equals(info.objA) && objB.Equals(info.objB) && sym.Equals(info.sym);
    }

    public override int GetHashCode()
    {
        return objA.GetHashCode() + objA.GetHashCode() + sym.GetHashCode();
    }
}
