using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganLifeLike
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        [SerializeField]
        private Rigidbody2D _rigidbody;
        public Vector3 startVelocity;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _spriteRenderer.flipX = startVelocity.x > 0;
            _rigidbody.velocity = startVelocity;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.gameObject.layer == 3)
            {
                Destroy(gameObject);
                return;
            }

            if (collision.collider.gameObject.layer != 26) return;

            collision.collider.gameObject.GetComponent<Player>().Damage(5);
            Destroy(gameObject);

        }
    }
}