using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hector
{
    public class FireballCool : FireballBehavior
    {

        public SpriteRenderer body;
        public SpriteRenderer eyes;
        public SpriteRenderer blue;
        public SpriteRenderer white;

        public bool drink { get; private set; }

        public override void Enable(float duration)
        {
            base.Enable(duration);

            body.enabled = false;
            eyes.enabled = false;
            blue.enabled = true;
            white.enabled = false;

            Invoke(nameof(Flash), duration / 2f);
        }

        public override void Disable()
        {
            base.Disable();

            body.enabled = true;
            eyes.enabled = true;
            blue.enabled = false;
            white.enabled = false;
        }

        private void Drink()
        {
            drink = true;
            fireball.SetPosition(fireball.home.inside.position);
            fireball.home.Enable(duration);

            body.enabled = false;
            eyes.enabled = true;
            blue.enabled = false;
            white.enabled = false;
        }

        private void Flash()
        {
            if (!drink)
            {
                blue.enabled = false;
                white.enabled = true;
                white.GetComponent<AnimatedSprite>().Restart();
            }
        }

        private void OnEnable()
        {
            blue.GetComponent<AnimatedSprite>().Restart();
            fireball.movement.speedMultiplier = 0.5f;
            drink = false;
        }

        private void OnDisable()
        {
            fireball.movement.speedMultiplier = 1f;
            drink = false;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Node node = other.GetComponent<Node>();

            if (node != null && enabled)
            {
                Vector2 direction = Vector2.zero;
                float maxDistance = float.MinValue;

                // Find the available direction that moves farthest from pacman
                foreach (Vector2 availableDirection in node.availableDirections)
                {
                    // If the distance in this direction is greater than the current
                    // max distance then this direction becomes the new farthest
                    Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                    float distance = (fireball.target.position - newPosition).sqrMagnitude;

                    if (distance > maxDistance)
                    {
                        direction = availableDirection;
                        maxDistance = distance;
                    }
                }

                fireball.movement.SetDirection(direction);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Cactus"))
            {
                if (enabled)
                {
                    Drink();
                }
            }
        }

    }
}