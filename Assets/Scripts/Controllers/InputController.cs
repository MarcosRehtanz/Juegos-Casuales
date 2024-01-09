using System;
using UnityEngine;

namespace InputController.Controllers
{
    interface IController
    {
        Vector2 Move();
    }
    [Serializable]
    public class Keyboard 
    {
        public KeyCode Up = KeyCode.UpArrow;
        public KeyCode Down = KeyCode.DownArrow;
        public KeyCode Left = KeyCode.LeftArrow;
        public KeyCode Right = KeyCode.RightArrow;
        public Vector2 Move()
        {
            float up = Input.GetKey(Up) ? 1 : 0;
            float down = Input.GetKey(Down) ? -1 : 0;
            float left = Input.GetKey(Left) ? -1 : 0;
            float right = Input.GetKey(Right) ? 1 : 0;
            Vector2 v2 = new(left+right, up+down);
            return v2;
        }
    }
}