using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AishaGrowth
{
    public class NeedsControl : MonoBehaviour
    {
        public int food, happiness, energy;
        public int foodTickRate, happinessTickRate, energyTickRate;

        public void Initialize(int food, int happiness, int energy)
        {
            this.food=food;
            this.happiness=happiness;
            this.energy=energy;
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
            }
        }

        public void ChangeFood(int amount)
        {
            food += amount;
            if(food < 0)
            {
                PetManager.Die();
            }
            else if (food > 100) food = 100;
        }
            public void ChangeHappiness(int amount)
        {
            happiness += amount;
            if(happiness < 0)
            {
                PetManager.Die();
            }
            else if (happiness > 100) happiness = 100;
        }
            public void ChangeEnergy(int amount)
        {
            energy += amount;
            if(energy < 0)
            {
                PetManager.Die();
            }
            else if (energy > 100) energy = 100;
        }
    }
}