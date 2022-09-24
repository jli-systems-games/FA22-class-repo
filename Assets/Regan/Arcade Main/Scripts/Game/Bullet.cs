using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan
{
    public class Bullet : MonoBehaviour
    {
        public Vector2 initialVelocity;
        [SerializeField] float drag;


        Vector2 _velocity;

        void Start()
        {
            _velocity = initialVelocity;
        }


        void Update()
        {
            _velocity -= _velocity.sqrMagnitude * 0.01f * drag * Time.deltaTime * _velocity.normalized;
            transform.position += new Vector3(_velocity.x, _velocity.y) * Time.deltaTime;
        }
    }
}