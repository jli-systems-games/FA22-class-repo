using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MarioBalance
{

    public class Player1Health : MonoBehaviour
    {
        public Image healthBar;
        public float healthAmount = 200;

        private void Update()
        {
            if (healthAmount <= 0)
            {
                SceneManager.LoadScene("MarioBalancePlayer2WinsScene");
            }
        }

        private void OnTriggerEnter2D(Collider2D collison)
        {
            if (collison.gameObject.tag == "Laser")
            {
                TakeDamage(20);
            }
        }

        public void TakeDamage(float Damage)
        {
            healthAmount -= Damage;
            healthBar.fillAmount = healthAmount / 200;
        }
    }
}