using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon.Project2.Scripts
{
    public class CameraAnimator : MonoBehaviour
    {

        public Animator anim;
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.RightShift) )
            {
                anim.Play("cameraBump");
            }
        }
    }
}


