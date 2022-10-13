using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon.Project2.Scripts
{
    public class CameraAnimator : MonoBehaviour
    {

        public Animator anim;
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.RightShift) )
            {
                anim.Play("cameraBump");
            }
        }
    }
}


