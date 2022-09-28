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
        //Input only go horizontal

        movement.x = Input.GetAxisRaw("Horizontal");
        
        
    }

    void FixedUpdate()
    {
        // The movement goes here

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    
	

}

}
