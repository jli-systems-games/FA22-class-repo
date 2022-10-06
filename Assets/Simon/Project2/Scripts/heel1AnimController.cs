using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon.Project2.Scripts 
{

    public class heel1AnimController : MonoBehaviour
    {

        public Animator anim;
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                anim.Play("size1fight");
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                anim.Play("size1flex");
            }
        }
    }

    
}
