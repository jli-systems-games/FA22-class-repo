using System.Collections;
using System.Collections.Generic;
using SharedAssets;
using Unity.VisualScripting;
using UnityEngine;


namespace JasonLi
{
    [RequireComponent(typeof(InputDispatcher), typeof(Rigidbody), typeof(Collider))]
    public class ArcadePlayer : MonoBehaviour
    {
        [SerializeField] private InputDispatcher _inputs;
        [SerializeField] private FloatParameter _jumpHeight;
        [SerializeField] private FloatParameter _spinStrength;

        private Rigidbody _rigidbody;
        private Collider _collider;

        void OnEnable()
        {
            _inputs.PrimaryButton += Jump;
        }

        void OnDisable()
        {
            _inputs.PrimaryButton -= Jump;
        }
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _collider = GetComponent<Collider>();
        }

        void Jump()
        {
            Debug.Log($"Jump is called for {_jumpHeight.Value}");
            _rigidbody.AddForce(Vector3.up * _jumpHeight);
            _rigidbody.AddTorque(-Vector3.forward * _jumpHeight);
        }
    }
}