using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon.Project2.Scripts
{
    public class EffectObject : MonoBehaviour
    {
        public float lifetime = 1f;
        void Start()
        {
        
        }

        void Update()
        {
            Destroy(gameObject, lifetime);
        }
    }

}
