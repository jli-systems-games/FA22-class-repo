using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioBalance
{

    public class PlayerControl : MonoBehaviour
    {
        public float speed = 10.4f;

        Rigidbody2D rb;

       void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            Vector3 pos = transform.position;

            if (Input.GetKey("w"))
            {
                pos.y += speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.y -= speed * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
                transform.Rotate(Vector3.forward * -5);
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
                transform.Rotate(Vector3.forward * 5);
            }

            rb.MovePosition(pos);
        }
    }
}