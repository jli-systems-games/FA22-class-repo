using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AishaLifelike
{
    public class HealthBar : MonoBehaviour
    {
        public Slider healthBar;
        public AishaLifelike.Health playerHealth;

        private void Start()
        {
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<AishaLifelike.Health>();
            healthBar = GetComponent<Slider>();
            healthBar.maxValue = playerHealth.maxHealth;
            healthBar.value = playerHealth.maxHealth;
        }

        public void SetHealth(int hp)
        {
            healthBar.value = hp;
        }
    }
}