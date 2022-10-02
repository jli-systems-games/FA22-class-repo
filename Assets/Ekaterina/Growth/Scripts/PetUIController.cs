using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ekaterina {

    public class PetUIController : MonoBehaviour
    { 
        public Slider needsSlider;
        public int petPoint = 1;
        public float needsBar = 1;
        public static PetUIController instance;
        
        private Animator animator;
        
        private void Start()
        {
            animator = gameObject.GetComponent<Animator>();

            needsSlider.value = 100;
        }
        public void Update()
    {
        
        animator.SetFloat("NeedsValue", needsSlider.value);

        needsSlider.value -= .01f;

    }

    public void ChangeSomething()
    {
        if (petPoint > 0)
        {
            needsSlider.value += needsBar;
        }
    }
    }
}

