using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace maiproject
{
    public class Fireball1 : MonoBehaviour
    {
        public GameObject enemy; 
        public float projectileSpeed;
        public Rigidbody2D rigidbody;
        public GameObject impacteffect;
        public Health enemyHealth;
        
        // Start is called before the first frame update
        void Start()
        {
            enemyHealth = enemy.GetComponent<Health>();
            rigidbody.velocity = transform.right*projectileSpeed;
            rigidbody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if((collision.gameObject.name == enemy.name))
            {
                //attack

                enemyHealth.takeDamage(7);
                Instantiate(impacteffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Debug.Log(enemyHealth.health);
            }
            if (collision.gameObject.CompareTag("Enemy"))
            {
               // Destroy(gameObject);
            }


            //var enemyComponent = GetComponent<EnemyHealth>();
        }
    }
}