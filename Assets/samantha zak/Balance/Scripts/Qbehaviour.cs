using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qbehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) //left
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }
        
    }
}
