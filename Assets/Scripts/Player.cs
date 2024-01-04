using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using PlayerManager;
using System;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    [SerializeField]
    private PlayerController playerController;

    void Start()
    {
        playerController = new PlayerController();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        playerController.ActionMove(rigidbody2D);
    }

}
