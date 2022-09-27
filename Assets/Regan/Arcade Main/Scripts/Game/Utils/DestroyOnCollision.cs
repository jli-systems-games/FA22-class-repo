using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan
{
    public class DestroyOnCollision : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }
    }
}