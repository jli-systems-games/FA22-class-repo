using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AishaPinball
{
public class PlayerControl : MonoBehaviour
{
    [SerializeField] private HingeJoint2D leftHinge;
    [SerializeField] private HingeJoint2D rightHinge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetAxis("Horizontal") < 0)
            {
                leftHinge.useMotor = true;
            }
            else
            {
                leftHinge.useMotor = false;
            }
             if (Input.GetAxis("Horizontal") > 0)
            {
                rightHinge.useMotor = true;
            }
            else
            {
                rightHinge.useMotor = false;
            }

// or we could just write this instead of all that ^^^ :
            // leftHinge.useMotor = Input.GetAxis("Horizontal") < 0;
            // rightHinge.useMotor = Input.GetAxis("Horizontal") > 0;
    }
}
}