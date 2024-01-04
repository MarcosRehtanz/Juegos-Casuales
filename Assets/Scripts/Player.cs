using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using PlayerManager;
using System;

public class Player : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField]

    void Start()
    {
        playerController = new PlayerController(this.GetComponent<CharacterController>());
    }


    // Update is called once per frame
    void Update()
    {
        playerController.ActionMove();
    }

}
