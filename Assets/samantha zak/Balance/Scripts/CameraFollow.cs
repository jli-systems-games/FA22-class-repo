using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamBalance
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform followTransform;


        //once per frame
        void FixedUpdate()
        {
            this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y,
                this.transform.position.z);


        }
    }
}