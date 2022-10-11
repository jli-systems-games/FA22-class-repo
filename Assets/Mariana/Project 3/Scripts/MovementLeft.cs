using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
    public class MovementLeft : MonoBehaviour
    {
        //this script controls the left leg
        private Rigidbody2D leftLeg;
        public float speedLeft;
        public float speedRight;


        //Here are some things I tried that did not work:

        //[SerializeField] private float speed = 18f;
        //[SerializeField] private HingeJoint2D leftHinge;
        //[SerializeField] private HingeJoint2D rightHinge;

        // Start is called before the first frame update
        void Start()
        {
            leftLeg = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                leftLeg.AddForce(new Vector2(speedLeft, 0), ForceMode2D.Impulse);
                //leftLeg.MovePosition(transform.position + Vector3.left);
            }
            if (Input.GetKey(KeyCode.W))
            {
                leftLeg.AddForce(new Vector2(speedRight, 0), ForceMode2D.Impulse);
                //  leftLeg.MovePosition(transform.position + Vector3.right);
            }

            //Here are some things I tried that did not work:

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