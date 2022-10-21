using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    

public class CameraFollow : MonoBehaviour
{
    public Camera cam;

    public GameObject beetle1;
    private Vector2 beetpos1;
    private Vector2 beetpos2;
    public GameObject beetle2;
    // Start is called before the first frame update
    void Start()
    {
        beetpos1 = beetle1.GetComponent<Transform>().position;
        beetpos2 = beetle2.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = new Vector3((beetpos1.x+beetpos2.x)/2, (beetpos1.y+beetpos2.y)/2, -10);
    }
}
}
