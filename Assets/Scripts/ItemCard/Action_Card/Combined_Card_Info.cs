using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combined_Card_Info
{
    public string concept_name;  //action card concept name
    public string nickname;  //action card concept nickname
    public Concept_Info concept_info; //action card concept information

    //Constructor for action card information holder
    public Combined_Card_Info(string nickname, string name, Concept_Info concept_info) {
        concept_name= name;
        this.nickname = nickname;
        this.concept_info = concept_info;
    }
}
