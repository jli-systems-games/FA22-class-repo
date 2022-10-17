using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerNumber = 1;
    private Rigidbody2D rb;
    public float speed=1;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"+playerNumber), Input.GetAxis("Vertical"+playerNumber))*speed;
        rb.velocity=move;
    }
}
