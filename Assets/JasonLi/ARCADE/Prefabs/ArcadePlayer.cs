using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using SharedAssets;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;


namespace JasonLi
{
    [RequireComponent(typeof(InputDispatcher), typeof(Rigidbody), typeof(Collider))]
    public class ArcadePlayer : MonoBehaviour
    {
        [SerializeField] private InputDispatcher _inputs;
        [SerializeField] private FloatParameter _jumpHeight;
        [SerializeField] private FloatParameter _spinStrength;
        [SerializeField] private Transform _jumpTarget;

        [SerializeField] private bool ShouldResetBeforeJumps; 

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

            //Reset parameters for a new jump
            if (ShouldResetBeforeJumps) ResetVelocities();
            
            // update direction of jump
            Vector3 directionToJump = _jumpTarget.position - transform.position;
            directionToJump = Vector3.Normalize(directionToJump) * _jumpHeight;

            // calculate spin
            Vector3 jumpSpin = Vector3.Cross(directionToJump,Vector3.right) * _spinStrength;
            
            // Apply forces
            _rigidbody.AddForce(directionToJump);
            _rigidbody.AddTorque(jumpSpin);
        }

        void ResetVelocities()
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }
}