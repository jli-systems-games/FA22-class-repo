using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class Stephanie : MonoBehaviour
    {
        public bool IsShaded { get; private set; } = false;

        void Update()
        {
            // TODO make this use OnTriggerEnter/Exit instead of Update
            if (Input.GetKey(KeyCode.Space))
            {
                IsShaded = true;
            }
            else
            {
                IsShaded = false;
            }
        }
    }
}