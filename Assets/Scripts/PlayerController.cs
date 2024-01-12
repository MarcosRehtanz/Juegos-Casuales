using UnityEngine;
using Actions.Controllers;
using Statistics.Models;
using Animations.Controller;
using InputController.Controllers;
using UnityEngine.Experimental.Rendering;

namespace PlayerManager
{
    public class PlayerController : MonoBehaviour
    {
        public StatisticsModel Stats;
        public Rigidbody2D Rb2D;
        public ActionsController Actions;
        public AnimationsController Animations;
        public Keyboard controller;
        public int FPS;

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
            Application.targetFrameRate = FPS;
        }

        void Update()
        {
            Application.targetFrameRate = FPS;

            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            bool charge = Input.GetKey(KeyCode.Q);

            if (charge)
            {
                Actions.Charge();
            }
            else
            {
                Actions.Move(x, y);
                Animations.Move(x, y);
            }
            Animations.HabilityOne(charge);
        }

    }

}