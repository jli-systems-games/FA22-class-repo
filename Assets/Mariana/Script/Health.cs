using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int health = 100;

        private int MAX_HEALTH = 100;


        private GameObject Player;

        private void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }
        // Update is called once per frame
        void Update()
        {

        }

        public void SetHealth(int maxHealth, int health)
        {
            this.MAX_HEALTH = maxHealth;
            this.health = health;
        }

        //private IEnumerable VisualIndicator(Color color)
        //{
         //   GetComponent<SpriteRenderer>().color = color;
         //   yield return new WaitForSeconds(0.15f);
         //   GetComponent<SpriteRenderer>().color = Color.white
       // }
        public void Damage(int amount)
        {
            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");

            }
            this.health -= amount;

            //StartCoroutine(VisualIndicator(Color.red));

            if (health <= 0)
            {
                Die();
            }

           
        }

        public void Heal(int amount)
        {
            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("Cannot have negative healing");

            }

            bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

            if(health + amount > MAX_HEALTH)
            {
                this.health += MAX_HEALTH;

            }
            else
            {
                this.health += amount;
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}