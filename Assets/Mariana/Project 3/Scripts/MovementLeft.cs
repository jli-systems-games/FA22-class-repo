using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
    public class MovementLeft : MonoBehaviour
    {
        private Rigidbody2D leftLeg;

        //[SerializeField] private float speed = 18f;
        //[SerializeField] private HingeJoint2D leftHinge;
        //[SerializeField] private HingeJoint2D rightHinge;

        // Start is called before the first frame update
        void Start()
        {
            leftLeg = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                leftLeg.MovePosition(transform.position + Vector3.left);
            }
            if (Input.GetKey(KeyCode.W))
            {
                leftLeg.MovePosition(transform.position + Vector3.right);
            }
            // if (Input.GetKeyDown(KeyCode.Space))
            // {

            // rightHinge.useMotor = Input.GetAxis("Horizontal") > 0;
            // leftHinge.useMotor = true;
            // }
            // else
            // {
            //    leftHinge.useMotor = false;
            //}
        }
    }

}