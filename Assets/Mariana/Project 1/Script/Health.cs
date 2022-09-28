using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Mariana
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int health = 100;

        public int MAX_HEALTH = 100;

   
        private Slider healthBar;

        private GameObject Player;

        
        private void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            healthBar = GetComponent<Slider>();
        }
        // Update is called once per frame
        void Update()
        {
            Debug.Log(health);

        }

        public void SetHealth(int maxHealth, int health)
        {
            this.MAX_HEALTH = maxHealth;
            this.health = health;
          // = (int) healthBar.value;
           
        }

       // private IEnumerable VisualIndicator(Color color)
       // {
         //   GetComponent<SpriteRenderer>().color = color;
           //yield return new WaitForSeconds(0.15f);
           // GetComponent<SpriteRenderer>().color = Color.white
       // }
        public void Damage(int amount)
        {
            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
                

            }
            this.health -= amount;

          // StartCoroutine(VisualIndicator(Color.red));

            if (health <= 0)
            {
                Die();
            }

           
        }

        private void Die()
        {
            Destroy(gameObject);
        }

        public static implicit operator float(Health v)
        {
            throw new NotImplementedException();
        }
    }
}
