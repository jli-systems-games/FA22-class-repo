using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace godzillabanana
{
    public class Health : MonoBehaviour
    {
        
        public int health;
        public int shieldRate;

        public HealthBar healthbar;
        // Start is called before the first frame update
        void Start()
        {
            healthbar.SetMaxHealth(health);
        }

        // Update is called once per frame
        void Update()
        {
            

        }
        public void takeDamage(int damageAmount)
        {
            health -= damageAmount - shieldRate;
            healthbar.SetHealth(health);
        }
    }
}