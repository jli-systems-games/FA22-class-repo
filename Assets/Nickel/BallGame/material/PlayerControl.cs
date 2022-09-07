using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NickelPinballWorkshop
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

            leftHinge.useMotor = Input.GetAxis("Horizontal") < 0;
            rightHinge.useMotor = Input.GetAxis("Horizontal") > 0;

        }
    }
}


