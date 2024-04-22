using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container_Info : Concept_Info
{
    //Concept Content
    public List<Concept_Info> contained_items;

    //Constructor for container concept
    public Container_Info(List<Concept_Info> items){
        concept_name = "Container";
        contained_items = items;
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

        //Checking if the number of inner element are the same
        Container_Info info = (Container_Info)obj;
        if (info.contained_items.Count != contained_items.Count) {
            return false;
        }
        //Checking if inner element are the same and in same order
        for (int i = 0; i < contained_items.Count; i++) {
            if (!contained_items[i].Equals(info.contained_items[i])){
                return false;
            }
        }
        return true;
    }

    public override int GetHashCode()
    {
        return contained_items.GetHashCode();
    }
}
