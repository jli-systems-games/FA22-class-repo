using TMPro;
using UnityEngine;

namespace Nickel.NickelBalanace.script
{
    public class PickUpObject : MonoBehaviour
    {
        public GameObject myHands;
        bool canpickup;
        GameObject ObjectIwantToPickUp;
        bool hasItem;

        public GameObject Cart;
        public GameObject test;

        public TMP_Text Instruction1;
        public TMP_Text Instruction2;

        // Start is called before the first frame update
        void Start()
        {
            Instruction1.text = " ";
            Instruction2.text = " ";
            canpickup = false;
            hasItem = false;
            
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(hasItem);
            if (canpickup == true && hasItem == false)
            {
                if (Input.GetKeyDown("e"))
                {
                    ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = true;
                    ObjectIwantToPickUp.transform.position = myHands.transform.position;
                    ObjectIwantToPickUp.transform.parent = myHands.transform;
                    hasItem = true;
                    canpickup = false;
                }
            }

            if (hasItem)
            {
                Instruction1.text = " 'Q' Drop Down";
                Instruction2.text = " 'Q' Drop Down";
            }
            if (hasItem==true && myHands.transform.childCount == 0)
            {
                canpickup = true;
                hasItem = false;
            }
            if (Input.GetKeyDown("q") && hasItem == true )
            {
                ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic = false;
                hasItem = false;
                canpickup=true;
                ObjectIwantToPickUp.transform.parent = null;
            }

            if (test.GetComponent<test>().closeToCart)
            {
                Transport();
            }
            
        }
        private void OnTriggerEnter(Collider other)
        {
            
 
               
                if (other.gameObject.tag == "Object" || other.gameObject.tag == "Ice" || other.gameObject.tag == "Fuel" || other.gameObject.tag == "GrillFish"
                || other.gameObject.tag == "Finish" || other.gameObject.tag == "Sushi")
                {

                    canpickup = true;  //set the pick up bool to true
                    if(canpickup && !hasItem)
                {
                    ObjectIwantToPickUp = other.gameObject;

                }
                    
                    Instruction1.text = " 'E' Pick Up";
                    Instruction2.text = " 'E' Pick Up";

                }
            
            
            
        }
        private void OnTriggerExit(Collider other)
        {
            canpickup = false;
            Instruction1.text = " ";
            Instruction2.text = " ";
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
