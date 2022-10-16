using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace nickelLifelike
{
    public class EnemyHealth : MonoBehaviour
    {

        public float startHealth = 10;
        public float health;

        private bool isDead = false;
        // Start is called before the first frame update
        void Start()
        {
            health = startHealth;
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(health);
        }

        public void TakeDamage(float amount)
        {

            health -= amount;
            if (health <= 0)
            {
                isDead = true;
                Destroy(gameObject);
            }
        }
    }

}
