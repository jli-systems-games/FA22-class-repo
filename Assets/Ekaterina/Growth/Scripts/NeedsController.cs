using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
        public class NeedsController : MonoBehaviour
        {
                public int food, happiness, energy;
                public int foodTickRate, happinessTickRate, energyTickRate;

                private void Awake()
                {
                        Initialize(100, 100, 100,5, 15, 7);
                }
                
                public void Initialize(int food, int happiness, int energy, int foodTickRate, int happinessTickRate,
                        int energyTickRate)
                {
                        this.food = food;
                        this.happiness = happiness;
                        this.energy = energy;
                        this.foodTickRate = foodTickRate;
                        this.happinessTickRate = happinessTickRate;
                        this.energyTickRate = energyTickRate;

                        if (this.food < 0) this.food = 0;
                        if (this.happiness < 0) this.happiness = 0;
                        if (this.energy < 0) this.energy = 0;

                        
                        PetUIController.instance.UpdateImages(this.food, this.happiness, this.energy);
                }


                private void Update()
                {
                        if (TimingManager.gameHourTimer < 0)
                        {
                                ChangeFood(-foodTickRate);
                                ChangeHappiness(-happinessTickRate);
                                ChangeEnergy(-energyTickRate);
                                
                                PetUIController.instance.UpdateImages(this.food, this.happiness, this.energy);
                        }
                }

                public void ChangeFood(int amount)
                {
                        food += amount;
                        if (food < 0)
                        {
                                PetManager.instance.Die();
                        }
                        else if (food > 100) food = 100;
                }

                public void ChangeHappiness(int amount)
                {
                        happiness += amount;
                        if (happiness < 0)
                        {
                                PetManager.instance.Die();
                        }
                        else if (happiness > 100) happiness = 100;

                }

                public void ChangeEnergy(int amount)
                {
                        energy += amount;
                        if (energy < 0)
                        {
                                PetManager.instance.Die();
                        }
                        else if (energy > 100) energy = 100;


                }
        }
}
