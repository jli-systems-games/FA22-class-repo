using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sam {
public class PotMove : MonoBehaviour
{
	
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;
    void Update()
    {
        //Input will go here

        movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        // The movement goes here

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    
	

}

}
