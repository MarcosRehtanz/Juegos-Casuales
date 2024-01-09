using System;
using Statistics.Models;
using UnityEngine;

namespace Actions.Controllers
{
    [Serializable]
    public class ActionsController
    {
        public StatisticsModel stats;
        public bool moving;
        public bool h1;
        public Rigidbody2D rigidbody2D;
        public ActionsController(StatisticsModel statistics)
        {
            stats = statistics;
        }
        public void Move(float x, float y)
        {
            moving = x != 0 || y != 0;
            Vector2 move = new(x, y);
            move.Normalize();
            rigidbody2D.velocity = stats.Speed() * Time.deltaTime * move;
        }
        public bool HabilityOne()
        {
            return Input.GetKey(KeyCode.Q);
        }
    }
}
