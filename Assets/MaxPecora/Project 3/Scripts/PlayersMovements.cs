using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace max
{

    public class PlayersMovements : MonoBehaviour
    {

        [Header("Movement")]
        public float moveSpeed;

        public float groundDrag;

        [Header("Ground Check")]
        public float playerHeight;
        public LayerMask whatIsGround;
        bool grounded;

        public Transform orientation;

        float horizontalInput;
        float verticalInput;

        Vector3 moveDirection;

        Rigidbody rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
        }

        private void Update()
        {
            //ground check
            if (tag == "Player")
            {
                grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
                Debug.Log("Is Grounded");
            }

            MyInput();

            //handle drag
            if (grounded) {
                rb.drag = groundDrag;
            }
            else {
                rb.drag = 0;
            }
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void MyInput()
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");
        }

        private void MovePlayer()
        {
            // calculate movement direction
            //moveDirection = orientation.forward * horizontalInput + orientation.right * verticalInput;

            moveDirection = new Vector3(0, 0, 0);
            moveDirection += Input.GetAxis("Vertical") * transform.right + Input.GetAxis("Horizontal") * transform.forward;
            rb.AddForce(moveDirection.normalized * moveSpeed * 4f, ForceMode.Force);
        }

    }
}
