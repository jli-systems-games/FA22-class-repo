using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


namespace Simon.Project4.Scripts
{
 
    public class TrayMover : MonoBehaviour
    {

        public GameObject tray;
            
        public float maxMoveSpeed = 30;
        public float smoothTime = 0.5f;
        Vector2 currentVelocity;
        void Update()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed); 
        }
    }
}