using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer2D : MonoBehaviour
{
    //private Rigidbody2D rigidBody2D;
    //[SerializeField] float moveSpeed = 2f;
    /// Start is called before the first frame update
    public float moveSpeed = 5;
    void Start()
    {
        //Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) //right
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        
        }
        /*
        else if (Input.GetKey(KeyCode.E)) //right
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        
        }
        

        else if (Input.GetKey(KeyCode.W)) //left
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.Q)) //left
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }*/
    }
}
