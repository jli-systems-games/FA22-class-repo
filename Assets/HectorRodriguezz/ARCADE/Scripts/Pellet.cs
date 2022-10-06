
using UnityEngine;

namespace Hector
{
    [RequireComponent(typeof(Collider2D))]
    public class Pellet : MonoBehaviour
    {
        public int points = 10;


        protected virtual void Drink()
        {

            FindObjectOfType<GameManager>().DrinkPellet(this);

        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Cactus"))
            {
                Drink();
            }
        }
    }
}