using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon
{
    
    public class ClawMovement : MonoBehaviour
    {
        private Rigidbody _rb;

        [SerializeField] private float speed = 1f;
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody>();
        }

        void Update()
        {

            _rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0 ,Input.GetAxis("Vertical")) * -speed;

        }
    }

}

