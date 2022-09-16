using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mariana
{

    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private int damage = 5;
        [SerializeField]
        //private float EnemyData data;

            private Rigidbody2D _rb;
        public Transform player;
        [SerializeField] private float speed = 18f;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
            SetEnemyValues();
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 direction = Vector2.MoveTowards(transform.position, player.position, speed);

            direction -= (Vector2)transform.position;
            _rb.velocity = direction;
        }

        private void SetEnemyValues()
        {
            //GetComponent<Health>().SetHealth(data.hp, data.hp);
            //damage = data.damage
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.CompareTag("Player"))
            {
                if (collider.GetComponent<Health>() != null)
                {
                    collider.GetComponent<Health>().Damage(damage);
                    this.GetComponent<Health>().Damage(10000);
                }


            }
        }

    }

}

