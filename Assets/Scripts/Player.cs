using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{
    [SerializeField]
    public Transform pos ;
    public float dirX = 0.0f;
    public float dirY = 0.0f;
    public float speed = 0.0f;
    public CharacterController characterController;

    void Start()
    {
        pos = this.GetComponent<Transform>();
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        ActionMove();
    }

    private void ActionMove()
    {
        dirX = Input.GetAxis("Horizontal") * speed;
        dirY = Input.GetAxis("Vertical") * speed;
        
        Vector3 move= new Vector3(dirX, dirY, 0) * Time.deltaTime;

        characterController.Move(move);
    }

}
