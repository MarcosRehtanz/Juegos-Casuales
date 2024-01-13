using UnityEngine;
using Actions.Controllers;
using Statistics.Models;
using Animations.Controller;
using InputController.Controllers;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

namespace PlayerManager
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject bullet;
        public StatsBasic initialStats;
        public StatisticsModel Stats;
        public Rigidbody2D Rb2D;
        public ActionsController Actions;
        public AnimationsController Animations;
        public Keyboard controller;
        public int FPS;

        void Start()
        {
            Stats = new StatisticsModel(initialStats);
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
            bool action1 = Input.GetMouseButtonUp(0);


            if (charge)
            {
                Actions.Charge();
                if (action1)
                {

                    Vector3 originPosition = transform.position;
                    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                    Actions.ActionOne(bullet,worldPosition, originPosition);
                }

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