using System;
using System.Collections;
using System.Collections.Generic;
using SharedAssets;
using UnityEngine;
using UnityEngine.UIElements;

namespace JasonLi
{
    public class JumpTarget : MonoBehaviour
    {
        [SerializeField] private Transform _origin;
        [SerializeField] private FloatParameter _rotationSpeed;

        public void Update()
        {
            Rotate();
        }

        public void Rotate()
        {
            transform.RotateAround(_origin.position, Vector3.forward, _rotationSpeed * Time.deltaTime);
        }
    }
}