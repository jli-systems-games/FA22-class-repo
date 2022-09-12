using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioAirHockey
{

    public class Player2Control : MonoBehaviour
    {
        public float speed = 10.4f;

        Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            Vector3 pos = transform.position;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                pos.y += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                pos.y -= speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pos.x -= speed * Time.deltaTime;
            }

            rb.MovePosition(pos);
        }
    }
}
