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
        public void Charge()
        {
            rigidbody2D.velocity = Vector2.zero;
        }
        public void ActionOne(GameObject bullet, Vector3 worldPosition, Vector3 originPosition)
        {
            worldPosition.z = 0;
            originPosition.y += 0.15f;
            Vector3 direction = worldPosition - originPosition;
            originPosition += direction * 0.1f;
            direction.Normalize();

            GameObject gameObject = MonoBehaviour.Instantiate(bullet, originPosition, new Quaternion());
            Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
            rigidbody2D.velocity = stats.SpeedAttack * Time.deltaTime * direction;
        }
    }
}
