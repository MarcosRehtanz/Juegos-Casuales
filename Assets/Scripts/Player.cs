using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using PlayerManager;

public class Player : MonoBehaviour
{
    private PlayerController playerController;

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
