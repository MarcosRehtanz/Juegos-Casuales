

using System;
using UnityEngine;

namespace Animations.Controller
{
    [Serializable]
    public class AnimationsController
    {
        public Animator animator;
        public Transform transform;

        public void Move(Vector2 moving)
        {
            animator.SetBool("run", Vector2.zero != moving);

            if (moving.x != 0)
            {
                if (moving.x > 0)
                    transform.localScale = new Vector3(1, 1, 1);
                else if (moving.x < 0)
                    transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        public void HabilityOne(bool charge){
            animator.SetBool("charge", charge);
        }
    }
}