using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelBalance
{
    public class PickUpObject : MonoBehaviour
    {
        public GameObject myHands;
        bool canpickup;
        GameObject ObjectIwantToPickUp;
        bool hasItem;

        public GameObject Cart;
        public GameObject test;
        
        // Start is called before the first frame update
        void Start()
        {
            canpickup = false;
            hasItem = false;
            
        }

        // Update is called once per frame
        void Update()
        {
            if (canpickup == true && hasItem == false)
            {
                if (Input.GetKeyDown("e"))
                {
                    ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = true;
                    ObjectIwantToPickUp.transform.position = myHands.transform.position;
                    ObjectIwantToPickUp.transform.parent = myHands.transform;
                    hasItem = true;
                }
            }
            if (Input.GetKeyDown("q") && hasItem == true)
            {
                ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = false;
                hasItem = false;
                ObjectIwantToPickUp.transform.parent = null;
            }

            if (test.GetComponent<test>().closeToCart)
            {
                Transport();
            }
            
        }
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Object")
            {
                
                canpickup = true;  //set the pick up bool to true
                ObjectIwantToPickUp = other.gameObject;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            canpickup = false;

        }

        private void Transport()
        {
            if (Input.GetKeyDown("f") && hasItem == true)
            {
                ObjectIwantToPickUp.transform.position = Cart.transform.position;
                ObjectIwantToPickUp.transform.parent = Cart.transform;
                hasItem = false;
                
            }
        }
    }

}
