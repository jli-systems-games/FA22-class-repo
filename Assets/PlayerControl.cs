using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private HingeJoint2D leftHinge;
    [SerializeField] private HingeJoint2D rightHinge;



    // Update is called once per frame
    void Update()
    {
        leftHinge.useMotor = Input.GetAxis("Horizontal") < 0;
        rightHinge.useMotor = Input.GetAxis("Horizontal") > 0;
    }
}
