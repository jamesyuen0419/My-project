using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Info : Concept_Info
{
    //Concept Content
    public string object_name;

    //Constructor for object concept
    public Object_Info(string obj_name) {
        concept_name = "Object";
        object_name = obj_name;
        this.nickname = obj_name;
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

        //Checking the stored object name are the same
        Object_Info info = (Object_Info)obj;
        return object_name == info.object_name;
    }

    public override int GetHashCode()
    {
        return object_name.GetHashCode();
    }
}
