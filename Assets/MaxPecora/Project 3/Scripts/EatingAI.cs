using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace max
{

    public class EatingAI : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Debug.Log("collision detected");
                Destroy(collision.gameObject);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
