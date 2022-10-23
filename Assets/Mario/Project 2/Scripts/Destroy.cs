using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioGrowth{
    public class Destroy : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Prey")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}