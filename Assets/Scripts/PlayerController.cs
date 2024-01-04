using System;
using UnityEngine;

namespace PlayerManager
{
    [Serializable]
    public class PlayerController
    {
        public float Speed = 1000.0f;
    
        public void ActionMove(Rigidbody2D rb2D)
        {
            float dirX = Input.GetAxis("Horizontal") * Speed;
            float dirY = Input.GetAxis("Vertical") * Speed;

           Vector2 v2 = new Vector2(dirX, dirY) * Time.deltaTime;

            rb2D.velocity = v2;
        }
    }

}