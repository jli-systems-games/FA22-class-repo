using Nickel.NickelBalanace.TheFirstPerson.Code.Player;
using UnityEngine;

namespace Nickel.NickelBalanace.script
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
            controller.GetComponent<FPSController>().enabled = false;
        }

        public void startMove()
        {
            controller.GetComponent<FPSController>().enabled = true;
        }
    }

}
