using UnityEngine;
using Actions.Controllers;
using Statistics.Models;
using Animations.Controller;
using InputController.Controllers;

namespace PlayerManager
{
    public class PlayerController : MonoBehaviour
    {
        public StatisticsModel Stats;
        public Rigidbody2D Rb2D;
        public ActionsController Actions;
        public AnimationsController Animations;
        public Keyboard controller;

        void Start()
        {
            Stats = new StatisticsModel(new StatsBasic()
            {
                Speed = 16
            });
            Actions = new ActionsController(Stats)
            {
                rigidbody2D = GetComponent<Rigidbody2D>()
            };
            Animations = new AnimationsController
            {
                animator = GetComponent<Animator>(),
                transform = GetComponent<Transform>()
            };
            controller = new Keyboard();
        }

        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            bool h1 = Input.GetKey(KeyCode.Q);

            Actions.Move(x, y);
            Animations.Move(x, y);

            Animations.HabilityOne(h1);
        }

    }

}