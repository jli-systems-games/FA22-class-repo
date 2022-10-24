using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan.Balance
{
    public class Ball : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag("Regan.balance.obstacle")) return;

            Destroy(gameObject);
        }
    }
}

