using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ekaterina {

    public class PetUIController : MonoBehaviour
    { 
        public Slider needsSlider;
        public int petFood = 1;
        public float needBar = 1;
        public static PetUIController instance;
        private void Start()
        {
            needsSlider.value = 100;
        }
        public void Update()
    {
        needsSlider.value -= .01f;
    }

    public void ChangeSomething()
    {
        if (petFood > 0)
        {
            needsSlider.value += needBar;
        }
    }
    }
}

