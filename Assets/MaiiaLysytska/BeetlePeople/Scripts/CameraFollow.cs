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
       
    }

    
    public void Update()
    {
        beetpos1 = beetle1.GetComponent<Transform>().position;
    beetpos2 = beetle2.GetComponent<Transform>().position;
        // How many units should we keep from the players
        float zoomFactor = 1.5f;
        float followTimeDelta = 0.8f;
 
        // Midpoint we're after
        Vector3 midpoint = ( beetpos1 +  beetpos2) / 2f;
 
        // Distance between objects
        float distance = ( beetpos1 -  beetpos2).magnitude;
 
        // Move camera a certain distance
        Vector3 cameraDestination = midpoint - cam.transform.forward * distance * zoomFactor;
 
        // Adjust ortho size if we're using one of those
        if (cam.orthographic)
        {
            // The camera's forward vector is irrelevant, only this size will matter
            cam.orthographicSize = distance;
        }
        // You specified to use MoveTowards instead of Slerp
        cam.transform.position = Vector3.Slerp(cam.transform.position, cameraDestination, followTimeDelta);
       
        // Snap when close enough to prevent annoying slerp behavior
        if ((cameraDestination - cam.transform.position).magnitude <= 0.05f)
            cam.transform.position = cameraDestination;
    }
}
}
