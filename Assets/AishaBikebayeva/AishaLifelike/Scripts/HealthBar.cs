using UnityEngine;
using UnityEngine.UI;

namespace AishaBikebayeva.AishaLifelike.Scripts
{
    public class HealthBar : MonoBehaviour
    {
        public Slider healthBar;
        public Health playerHealth;

        private void Start()
        {
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
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