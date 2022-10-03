using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{
    public class DifficultyController : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject player;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (LightUp.finishedLH == 2)
            {
                TheFirstPerson.FPSController.sprintEnabled = false;
            }
        }
    }

}

