using System;
using Statistics.Models;
using UnityEngine;

namespace Actions.Controllers
{
    [Serializable]
    public class ActionsController
    {
        public StatisticsModel stats;
        public Vector2 moveDirection;
        public bool moving;
        public ActionsController(StatisticsModel statistics)
        {
            stats = statistics;
        }
        public void Move()
        {
            float dirX = Input.GetAxis("Horizontal");
            float dirY = Input.GetAxis("Vertical");
            moving = dirX != 0 || dirY != 0;
            Vector2 move = new(dirX, dirY);
            move.Normalize();
            moveDirection = stats.Speed * Time.deltaTime * move;
        }
    }
}
