using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sam
{
    public class Destroy : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Leaf"))
            {
                Destroy(collision.gameObject);
            }

            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
            }
        }

    }
}