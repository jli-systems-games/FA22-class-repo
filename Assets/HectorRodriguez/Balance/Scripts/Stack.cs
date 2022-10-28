using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{


    public class Stack : MonoBehaviour
    { 

        private void OnTriggerEnter(Collider stacking)
        {
            if (stacking.CompareTag("Concha"))
            {
                stacking.transform.parent = GameObject.Find("ConchasList").transform;
            }

        }
    }
}