using UnityEngine;

namespace Nickel.NickelBalanace.script
{
    public class test : MonoBehaviour
    {
        // Start is called before the first frame update
        public bool closeToCart=false;
        
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log("enter");
            closeToCart = true;
        }
        private void OnTriggerExit(Collider other)
        {
            closeToCart = false;
        }
    }

}
