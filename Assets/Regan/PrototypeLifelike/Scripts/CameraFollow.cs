using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ReganLifeLike
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField]
        private float _followSpeed = 1;

        [SerializeField]
        private Transform _followTransform;

        [SerializeField]
        private float _yMinClamp = 0.5f;

        void Update()
        {
            Vector2 position2D = new(transform.position.x, transform.position.y);
            Vector2 newPosition2D = Vector2.Lerp(position2D, _followTransform.position, _followSpeed * Time.deltaTime);
            newPosition2D.y = Mathf.Clamp(newPosition2D.y, _yMinClamp, Mathf.Infinity);
            transform.position = new Vector3(newPosition2D.x, newPosition2D.y, transform.position.z);
        }
    }
}