using System.Collections;
using System.Collections.Generic;
using UnityEngine;




 namespace SowGrowBloom 
    {

 

public class Wei2_PlayerMovement : MonoBehaviour
{

         
        public float moveSpeed = 5f;
        public Rigidbody2D rb;
        Vector2 movement;
       
        void Start()
    {

    }

    
    void Update()
    {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");



        }


        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            
        }
    }

}