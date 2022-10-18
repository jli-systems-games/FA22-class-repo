using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AishaLifelike
{
    public class Health : MonoBehaviour
    {
        public int curHealth = 0;
        public int maxHealth = 100;

        public AishaLifelike.HealthBar healthBar;

        void Start()
        {
            curHealth = maxHealth;
        }

        // void Update(){
        //     OnCollisionEnter();
        // }
        
        void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.tag == "Projectile")
            {
                curHealth = maxHealth - 20;
                healthBar.SetHealth( curHealth );
                Debug.Log("Player was hit");
            }
        }

        // public void DamagePlayer( int damage )
        // {
        //     curHealth -= damage;

        //     healthBar.SetHealth( curHealth );
        // }
    }
}