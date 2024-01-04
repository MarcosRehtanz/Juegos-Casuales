using System;
using UnityEngine;

namespace PlayerManager
{
    [Serializable]
    public class PlayerController
    {
        public CharacterController characterController;
        public float speed { get; set; } = 10.0f;


        public PlayerController(CharacterController character)
        {
            characterController = character;
        }

        public void ActionMove()
        {
            float dirX = Input.GetAxis("Horizontal") * speed;
            float dirY = Input.GetAxis("Vertical") * speed;

            Vector3 move = new Vector3(dirX, dirY, 0) * Time.deltaTime;

            characterController.Move(move);
        }
    }

}