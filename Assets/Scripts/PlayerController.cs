using UnityEngine;
using Actions.Controllers;
using Statistics.Models;
using Animations.Controller;

namespace PlayerManager
{
    public class PlayerController : MonoBehaviour
    {
        public StatisticsModel Stats;
        public Rigidbody2D Rb2D;
        public ActionsController Actions;
        public AnimationsController Animations;
        public Vector2 MoveDirection;

        public void Inizalizer()
        {
            Stats = new StatisticsModel(new StatsBasic()
            {
                Speed = 16
            });
            Rb2D = GetComponent<Rigidbody2D>();
            Actions = new ActionsController(Stats);
            Animations = new AnimationsController
            {
                animator = GetComponent<Animator>(),
                transform = GetComponent<Transform>()
            };
        }

        public void ActionMove()
        {
            MoveDirection = Actions.Move();
            Animations.Move(MoveDirection);
            Rb2D.velocity = MoveDirection;
        }

        public void HabilityOne()
        {
            bool h1 = Actions.HabilityOne();
            Animations.HabilityOne(h1);
        }
    }

}