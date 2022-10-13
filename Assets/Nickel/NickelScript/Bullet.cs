using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NickelArcade
{
    public class Bullet : MonoBehaviour
    {
        // Start is called before the first frame update
        public float bulletSpeed = 15f;
        public float bulletDamage = 10f;
        public Rigidbody2D rb;

        private void FixedUpdate()
        {
            rb.velocity = transform.right * bulletSpeed;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
        }
    }
}

