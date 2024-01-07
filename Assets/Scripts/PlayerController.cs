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

        public void Inizalizer()
        {
            Stats = new StatisticsModel
            {
                Speed = 50
            };
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
            Actions.Move();
            Animations.Move(Actions.moveDirection);
            Rb2D.velocity = Actions.moveDirection;
        }
    }

}