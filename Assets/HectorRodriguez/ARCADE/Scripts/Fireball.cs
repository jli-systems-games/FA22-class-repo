using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hector
{
    [RequireComponent(typeof(Movement))]
    public class Fireball : MonoBehaviour
    {
        public Movement movement { get; private set; }
        public FireballHome home { get; private set; }
        public FireballScatter scatter { get; private set; }
        public FireballChase chase { get; private set; }
        public FireballCool cool { get; private set; }
        public FireballBehavior initialBehavior;
        public Transform target;
        public int points = 200;


        private void Awake()
        {
            movement = GetComponent<Movement>();
            home = GetComponent<FireballHome>();
            scatter = GetComponent<FireballScatter>();
            chase = GetComponent<FireballChase>();
            cool = GetComponent<FireballCool>();
        }

        private void Start()
        {
            ResetState();
        }

        public void ResetState()
        {
            gameObject.SetActive(true);
            movement.ResetState();

            cool.Disable();
            chase.Disable();
            scatter.Enable();

            if (home != initialBehavior)
            {
                home.Disable();
            }

            if (initialBehavior != null)
            {
                initialBehavior.Enable();
            }
        }

        public void SetPosition(Vector3 position)
        {
            // Keep the z-position the same since it determines draw depth
            position.z = transform.position.z;
            transform.position = position;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Cactus"))
            {
                if (cool.enabled)
                {
                    FindObjectOfType<GameManager>().FireBallDeath(this);
                }
                else
                {
                    FindObjectOfType<GameManager>().CactusDeath();
                }
            }
        }

    }


}
