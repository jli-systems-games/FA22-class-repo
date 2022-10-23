using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
    public class MarsPlayer : MonoBehaviour
    {
        public bool IsShaded { get; private set; } = false;

        private void OnTriggerEnter(Collider collider)
        {
            // TODO make this use OnTriggerEnter/Exit instead of Update
            if (collider.gameObject.name == "Cube")
            {
                IsShaded = true;
            }
            else
            {
                IsShaded = false;
            }
        }
        
        private void OnTriggerExit(Collider collider)
        {
            // TODO make this use OnTriggerEnter/Exit instead of Update
            if (collider.gameObject.name == "Cube")
            {
                IsShaded = false;
            }
            else
            {
                IsShaded = true;
            }
        }
    }
}