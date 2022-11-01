using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelBalance
{
    public class DestroyObejct : MonoBehaviour
    {
        public int ID;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (ID == 2)
            {
                if (other.CompareTag("Ice"))
                {
                    Destroy(other.gameObject);
                }
            }

            if (ID == 1)
            {
                if (other.CompareTag("Fuel"))
                {
                    Destroy(other.gameObject);
                }
            }

        }

    }

}
