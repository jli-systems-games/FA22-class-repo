using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Simon.Project3.Scripts
{
    public class HotDogger : MonoBehaviour
    {

        public GameObject hotdog;
        
        void Start()
        {
        
        }

        void Update()
        {
            hotdog.transform.position = Input.mousePosition;

            if (Input.GetMouseButtonDown(0))
            {
                hotdog.gameObject.SetActive(true);
            }

            if (Input.GetMouseButtonUp(0))
            {
                hotdog.gameObject.SetActive(false);
            }
        }
    }

}

