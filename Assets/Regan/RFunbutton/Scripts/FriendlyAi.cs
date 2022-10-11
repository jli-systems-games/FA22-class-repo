using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyAi : MonoBehaviour
{
    Transform target;
    public float speed = 3f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        target = GameObject.FindWithTag("Enemy").transform;

        Vector3 forwardAxis = new Vector3(0, 0, -1);

        transform.LookAt(target.position, forwardAxis);
        Debug.DrawLine(transform.position, target.position);
        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        transform.position -= transform.TransformDirection(Vector2.up) * speed;
    }
}