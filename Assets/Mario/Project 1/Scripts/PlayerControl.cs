using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioArcadeSoccer
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
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
            }

            rb.MovePosition(pos);
        }
    }
}