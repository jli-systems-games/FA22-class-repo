using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Simon.Project4.Scripts
{
    public class CameraZoom : MonoBehaviour
    {

        public GameObject cameraHolder;
        void Start()
        {
        
        }

        private float t = 0;
        void Update()
        {
            t += Time.deltaTime;
            cameraHolder.transform.localScale = new Vector3(t, t, t);
        }
    }

}
