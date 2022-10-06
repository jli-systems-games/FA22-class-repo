using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Max
{

    public class ItemCollector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Growth"))
            {
                Destroy(collision.gameObject);
                transform.localScale += new Vector3(2, 2, 2);
            } 
            if (collision.gameObject.CompareTag("Shrink"))
            {
                Destroy(collision.gameObject);
                transform.localScale += new Vector3(-2, -2, 0);
            }
        }
    }
}
