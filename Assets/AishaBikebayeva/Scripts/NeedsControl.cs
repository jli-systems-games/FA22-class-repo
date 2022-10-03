using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

namespace AishaGrowth
{
    public class NeedsControl : MonoBehaviour
    {
        public int food, happiness, energy;
        public int foodTickRate, happinessTickRate, energyTickRate;
        public DateTime lastTimeFed, lastTimeGainedEnergy, lastTimeHappy;

        private void Awake()
        {
            Initialize(100,100,100,5,7,15);
        }

        public void Initialize(int food, int happiness, int energy, int foodTickRate, int happinessTickRate, int energyTickRate)
        {
            lastTimeFed = DateTime.Now;
            lastTimeHappy = DateTime.Now;
            lastTimeGainedEnergy = DateTime.Now;
            this.food=food;
            this.happiness=happiness;
            this.energy=energy;
            this.foodTickRate=foodTickRate;
            this.happinessTickRate=happinessTickRate;
            this.energyTickRate=energyTickRate;
            AishaGrowth.PetUIController.instance.UpdateImages(food,happiness,energy);
        }

        public void Initialize(int food, int happiness, int energy)
        {
            this.food=food;
            this.happiness=happiness;
            this.energy=energy;
            this.foodTickRate=foodTickRate;
            this.happinessTickRate=happinessTickRate;
            this.energyTickRate=energyTickRate;
            AishaGrowth.PetUIController.instance.UpdateImages(food,happiness,energy);
        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        private void Update()
        {
            if(TimingManager.gameHourTimer < 0)
            {
                ChangeFood(-foodTickRate);
                ChangeEnergy(-energyTickRate);
                ChangeHappiness(-happinessTickRate);
                AishaGrowth.PetUIController.instance.UpdateImages(food,happiness,energy);
            }
        }

        public void ChangeFood(int amount)
        {
            food += amount;
            if(food < 0)
            {
                PetManager.Die();
                SceneManager.LoadSceneAsync("GameOver");
            }
            else if (food > 100) food = 100;
        }
        public void ChangeHappiness(int amount)
        {
            happiness += amount;
            if(happiness < 0)
            {
                PetManager.Die();
                SceneManager.LoadSceneAsync("GameOver");
            }
            else if (happiness > 100) happiness = 100;
        }
        public void ChangeEnergy(int amount)
        {
            energy += amount;
            if(energy < 0)
            {
                PetManager.Die();
                SceneManager.LoadSceneAsync("GameOver");
            }
            else if (energy > 100) energy = 100;
        }
    }
}