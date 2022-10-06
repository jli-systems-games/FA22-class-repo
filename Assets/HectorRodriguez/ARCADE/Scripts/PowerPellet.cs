using UnityEngine;

namespace Hector
{
    public class PowerPellet : Pellet
    {
        public float duration = 8.0f;

        protected override void Drink()
        {
            FindObjectOfType<GameManager>().DrinkPowerPellet(this);
        }
    }
}