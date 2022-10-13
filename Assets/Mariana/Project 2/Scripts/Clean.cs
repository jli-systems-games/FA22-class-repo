using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mariana
{
    
    public class Clean : MonoBehaviour
    {
        public GameObject eat;
  
    
        void OnTriggerStay2D(Collider2D other)

        {
            
            if (Input.GetKeyDown(KeyCode.Space) && other.gameObject.tag == "Enemy" )
            {
                Destroy(other.gameObject);
            }

        }

    }
    
}
