using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using PlayerManager;
using System;

public class Player : PlayerController
{
    void Start()
    {
        Inizalizer();
    }


    // Update is called once per frame
    void Update()
    {
        ActionMove();
        HabilityOne();
    }

}
