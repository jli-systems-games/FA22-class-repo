using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ekaterina {

    public class PetUIController : MonoBehaviour
    { 
        public Slider healthSlider;
        public int petFood = 1;
        
        public float needBar = 1;
    
       public Image foodImage, happinessImage, energyImage;
        public static PetUIController instance;

        private void Start()
        {
            healthSlider.value = 100;
        }

        private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetUIController in the Scene");
    }

    public void UpdateImages(int food, int happiness, int energy)
    {
        foodImage.fillAmount = (float) food / 100;
        happinessImage.fillAmount = (float) happiness / 100;
        energyImage.fillAmount = (float) energy / 100;
    }

    public void Update()
    {
        healthSlider.value -= .01f;
    }

    public void ChangeSomething()
    {
        if (petFood > 0)
        {
        healthSlider.value += needBar;
        }
    }
    }
}

