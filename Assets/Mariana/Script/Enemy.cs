using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Mariana

{

    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private int damage = 5;
        [SerializeField]
        public EnemyData data;

        private Rigidbody2D _rb;
        public Transform player;
        [SerializeField] private float speed = 18f;

        // Start is called before the first frame update
        void Start()
        {
  
        }

        // Update is called once per frame
        void Update()
        {
            if (GameObject.Find("Player") != null)
            {
                player = GameObject.Find("Player").transform;

                _rb = transform.GetComponent<Rigidbody2D>();
                SetEnemyValues();
                Vector2 direction = Vector2.MoveTowards(transform.position, player.position, speed);

                direction -= (Vector2)transform.position;
                _rb.velocity = direction;
            }
            else
            {
                SceneManager.LoadScene("EndBad");
            }


   
         
        }

        private void SetEnemyValues()
        {
            GetComponent<Health>().SetHealth(data.hp, data.hp);
            damage = data.damage;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.CompareTag("Player"))
            {
                if (collision.transform.GetComponent<Health>() != null)
                {
                    collision.transform.GetComponent<Health>().Damage(damage);
                    this.GetComponent<Health>().Damage(10000);
                    
                }

              

            }
          
        }


    }

}

