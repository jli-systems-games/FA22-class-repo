using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Mariana
{
    public class Animations : MonoBehaviour
    {
        bool attacking;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                attacking = true;

            }

        }
    }

}