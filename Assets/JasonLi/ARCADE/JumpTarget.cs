using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using SharedAssets;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

namespace JasonLi
{
    public class JumpTarget : MonoBehaviour
    {
        [SerializeField] private Transform _origin;
        [SerializeField] private FloatParameter _rotationSpeed;

        private float _localAngle;

        private float _distanceFromOrigin;
        public void Start()
        {
            _distanceFromOrigin = Vector3.Distance(_origin.position, transform.position);
            _localAngle = 0f;
        }
        public void Update()
        {
            Rotate();
        }

        public void Rotate()
        {
            _localAngle = ( _localAngle + Time.deltaTime * _rotationSpeed ) %  (Mathf.PI * 2f);
            transform.position = _origin.position + _distanceFromOrigin * new Vector3(Mathf.Cos(_localAngle), Mathf.Sin(_localAngle), 0f);
        }
    }
}