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
        public ActionsController(StatisticsModel statistics)
        {
            stats = statistics;
        }
        public Vector2 Move()
        {
            float dirX = Input.GetAxis("Horizontal");
            float dirY = Input.GetAxis("Vertical");
            moving = dirX != 0 || dirY != 0;
            Vector2 move = new(dirX, dirY);
            move.Normalize();
            return stats.GetSpeed() * Time.deltaTime * move;
        }
        public bool HabilityOne(){
            return Input.GetKey(KeyCode.Q);
        }
    }
}
