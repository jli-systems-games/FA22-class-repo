using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aisha
{

    public class boat : MonoBehaviour
    {
        public float speed = 1;//0.0f;
        public Rigidbody2D rb;
        public Vector2 movement;
        float rightEdge = 10f; //the right edge of the screen in world coordinates
        float leftEdge = -10f;
        float upEdge = 7f;
        float downEdge = -5f;
    
        // Start is called before the first frame update
        void Start()
        {
            rb = this.GetComponent<Rigidbody2D>();

               rb.velocity = new Vector2(-speed, 0);
            //    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        }

        // Update is called once per frame
        void Update()
        {
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0);
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                transform.position += new Vector3(0,speed * Time.deltaTime);
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                transform.position += new Vector3(0,-speed * Time.deltaTime);
            }

        
            if (transform.position.x > rightEdge)
            {
                transform.position = new Vector2(rightEdge, transform.position.y);
            }
            if (transform.position.x < leftEdge)
            {
                transform.position = new Vector2(leftEdge, transform.position.y);
            }
            if (transform.position.y > upEdge)
            {
                transform.position = new Vector2(transform.position.x, upEdge);
            }
            if (transform.position.y < downEdge)
            {
                transform.position = new Vector2(transform.position.x, downEdge);
            }
        }   
        void FixedUpdate()
        {
            moveCharacter(movement);
        }
        void moveCharacter(Vector2 direction)
        {
            rb.AddForce(direction * speed);
        }

    }

}