using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
        public class AnimationController : MonoBehaviour
        {
                Animator animator;
                void Start()
                {
                        animator = gameObject.GetComponent<Animator>();
                }
                private void Update()
                {
                       /* if (food < 80)
                        {
                                animator.SetTrigger("Sad");
                        }
                        
                        if (food > 80)
                        {
                                animator.SetTrigger("Happy");
                        }
                        
                        if (energy < 50)
                        {
                                animator.SetFloat(energy);
                        }
                        
                        
                        */
                        
                       
                }
        }
}
