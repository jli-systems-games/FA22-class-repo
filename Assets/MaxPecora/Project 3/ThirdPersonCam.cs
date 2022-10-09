using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace max
{

    public class ThirdPersonCam : MonoBehaviour
    {
        [Header("References")]
        public Transform orientation;
        public Transform player;
        public Transform playerObj;
        public Rigidbody rb;

        public float rotationSpeed;

        public void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        public void update()
        {
            //roation orientation
            Vector3 viewDir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
            orientation.forward = viewDir.normalized;

            //rotate player object
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticleInput = Input.GetAxis("Verticle");
            Vector3 inputDir = orientation.forward * verticleInput + orientation.right * horizontalInput;

            if (inputDir != Vector3.zero)
                playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }

    }
}