

using System;
using UnityEngine;

namespace Animations.Controller
{
    [Serializable]
    public class AnimationsController
    {
        public Animator animator;
        public Transform transform;

        public void Move(float x, float y)
        {
            animator.SetBool("run", x != 0 || y != 0);

            if (x != 0)
            {
                if (x > 0)
                    transform.localScale = new Vector3(1, 1, 1);
                else if (x < 0)
                    transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        public void HabilityOne(bool charge)
        {
            animator.SetBool("charge", charge);
        }
    }
}