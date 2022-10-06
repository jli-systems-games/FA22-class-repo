using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana

{
    
    public class Clean : MonoBehaviour
    {
        public GameObject eat;

        public int index;


        private void Update()
        {
            
            GameObject[] gameObjects;
            gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            if (gameObjects.Length == 0)
            {
                SceneManager.LoadScene("Island"+index);
                //Debug.Log("now what");
            }
            
        }
        void OnTriggerStay2D(Collider2D other)

        {
            
            if (Input.GetKeyDown(KeyCode.Space) && other.gameObject.tag == "Enemy" )
            {
                Destroy(other.gameObject);
            }

        }

    }
    
}
