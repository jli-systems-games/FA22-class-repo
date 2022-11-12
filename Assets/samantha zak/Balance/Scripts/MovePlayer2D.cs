using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamBalance
{
    public class MovePlayer2D : MonoBehaviour
    {
        //private Rigidbody2D rigidBody2D;
        //[SerializeField] float moveSpeed = 2f;
        /// Start is called before the first frame update
        public float moveSpeed = 1;

        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D)) //right
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;

            }

            else if (Input.GetKey(KeyCode.A)) //left
            {
                transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

            }


            else if (Input.GetKey(KeyCode.W)) //up
            {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.S)) //down
            {
                transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

            }
        }
    }
}