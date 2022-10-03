using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ekaterina
{
        public class AnimationController : MonoBehaviour
        {
                public Slider FoodBar;
                public Slider EnergyBar;
                public Slider HappinessBar;


                Animator animator;
                void Start()
                {
                        animator = gameObject.GetComponent<Animator>();
                }
                private void Update()
                {
                        
                        if (FoodBar.value < 80)
                        {
                                animator.SetTrigger("Sad");
                        }
                        
                        
                        if (EnergyBar.value < 80)
                        {
                                animator.SetTrigger("Sad");
                        }

                        if (HappinessBar.value < 80)
                        {
                                animator.SetTrigger("Sad");
                        }
                        
                        if (FoodBar.value > 80 && EnergyBar.value > 80 && HappinessBar.value > 80)
                        {
                                animator.SetTrigger("Happy");
                        }

                }
       
        }
}
