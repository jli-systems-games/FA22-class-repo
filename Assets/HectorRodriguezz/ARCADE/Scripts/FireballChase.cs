using UnityEngine;

namespace Hector
{
    public class FireballChase : FireballBehavior
    {
        private void OnDisable()
        {
            fireball.scatter.Enable();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Node node = other.GetComponent<Node>();

            // Do nothing while the ghost is frightened
            if (node != null && enabled && !fireball.cool.enabled)
            {
                Vector2 direction = Vector2.zero;
                float minDistance = float.MaxValue;

                // Find the available direction that moves closet to pacman
                foreach (Vector2 availableDirection in node.availableDirections)
                {
                    // If the distance in this direction is less than the current
                    // min distance then this direction becomes the new closest
                    Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                    float distance = (fireball.target.position - newPosition).sqrMagnitude;

                    if (distance < minDistance)
                    {
                        direction = availableDirection;
                        minDistance = distance;
                    }
                }

                fireball.movement.SetDirection(direction);
            }
        }

    }

}