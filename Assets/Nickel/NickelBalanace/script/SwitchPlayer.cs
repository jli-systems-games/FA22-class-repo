using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelBalance
{
    public class SwitchPlayer : MonoBehaviour
    {
        public GameObject controller;
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

            
                
                
        }

        public void stopMove()
        {
            controller.GetComponent<TheFirstPerson.FPSController>().enabled = false;
        }

        public void startMove()
        {
            controller.GetComponent<TheFirstPerson.FPSController>().enabled = true;
        }
    }

}
