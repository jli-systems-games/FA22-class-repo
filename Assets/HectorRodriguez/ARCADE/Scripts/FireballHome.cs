using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hector
{
    public class FireballHome : FireballBehavior
    {
        public Transform inside;
        public Transform outside;

        private void OnEnable()
        {
            StopAllCoroutines();
        }

        private void OnDisable()
        {
            // Check for active self to prevent error when object is destroyed
            if (gameObject.activeInHierarchy)
            {
                StartCoroutine(ExitTransition());
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // Reverse direction everytime the ghost hits a wall to create the
            // effect of the ghost bouncing around the home
            if (enabled && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
            {
                fireball.movement.SetDirection(-fireball.movement.direction);
            }
        }

        private IEnumerator ExitTransition()
        {
            // Turn off movement while we manually animate the position
            fireball.movement.SetDirection(Vector2.up, true);
            fireball.movement.rigidbody.isKinematic = true;
            fireball.movement.enabled = false;

            Vector3 position = transform.position;

            float duration = 0.5f;
            float elapsed = 0f;

            // Animate to the starting point
            while (elapsed < duration)
            {
                fireball.SetPosition(Vector3.Lerp(position, inside.position, elapsed / duration));
                elapsed += Time.deltaTime;
                yield return null;
            }

            elapsed = 0f;

            // Animate exiting the ghost home
            while (elapsed < duration)
            {
                fireball.SetPosition(Vector3.Lerp(inside.position, outside.position, elapsed / duration));
                elapsed += Time.deltaTime;
                yield return null;
            }

            // Pick a random direction left or right and re-enable movement
            fireball.movement.SetDirection(new Vector2(Random.value < 0.5f ? -1f : 1f, 0f), true);
            fireball.movement.rigidbody.isKinematic = false;
            fireball.movement.enabled = true;
        }

    }
}