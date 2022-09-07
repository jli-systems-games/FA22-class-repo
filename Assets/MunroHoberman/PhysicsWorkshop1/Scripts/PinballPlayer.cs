using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MunroHobermanPinball
{
    public class PinballPlayer : MonoBehaviour
    {
        // Start is called before the first frame update
        public HingeJoint2D flipperLeft;
        public HingeJoint2D flipperRight;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                flipperLeft.useMotor = true;
            }
            else
            {
                flipperLeft.useMotor = false;
            }

            if (Input.GetAxis("Horizontal") > 0)
            {
                flipperRight.useMotor = true;
            }
            else
            {
                flipperRight.useMotor = false;
            }
        }
    } 
}

