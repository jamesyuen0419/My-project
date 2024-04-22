using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combined_Card_Info
{
    public String concept_name;
    public String nickname;
    public Concept_Info concept_info;

    public Combined_Card_Info(String nickname, String name, Concept_Info concept_info) {
        concept_name= name;
        this.nickname = nickname;
        this.concept_info = concept_info;
    }
}
