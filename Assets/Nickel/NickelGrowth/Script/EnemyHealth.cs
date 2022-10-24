using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace nickelLifelike
{
    public class EnemyHealth : MonoBehaviour
    {
        public GameObject healthBar;
        public float startHealth = 10;
        public float health;

        private Vector3 lTemp;

        private bool isDead = false;
        // Start is called before the first frame update
        void Start()
        {
            health = startHealth;
            lTemp = healthBar.transform.localScale;
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(health);
            
        }

        public void TakeDamage(float amount)
        {

            health -= amount;
            lTemp.x-= 1 / 12f;
            healthBar.transform.localScale = lTemp;
            if (health <= 0)
            {
                isDead = true;
                Destroy(gameObject);
            }
        }

        public void ThornDamage()
        {
            StartCoroutine(dotDamage());
        }

        IEnumerator dotDamage()
        {
            Debug.Log(health);
            lTemp.x -= 1 / 12f;
            healthBar.transform.localScale = lTemp;
            health -= 1;
            yield return new WaitForSeconds(2);
            lTemp.x -= 1 / 12f;
            healthBar.transform.localScale = lTemp;
            health -= 1;
            
            
        }
        
    }

}
