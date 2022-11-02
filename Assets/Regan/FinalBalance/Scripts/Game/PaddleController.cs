using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Regan.Balance
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PaddleController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private float _mouseSensitivity = 250f;
        [SerializeField]
        private float _paddleClampAngle = 50f;

        private float _mouseDeltaX = 0;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            HandleInput();
            UpdatePaddleRotation();
        }

        private void UpdatePaddleRotation()
        {
            float clampedMouseDelta = Mathf.Clamp(_mouseDeltaX, -1, 1);
            float zRotation = Mathf.Clamp(_rigidbody.rotation - clampedMouseDelta * _mouseSensitivity * Time.deltaTime, -_paddleClampAngle, _paddleClampAngle);
            transform.rotation = Quaternion.Euler(0, 0, zRotation);
                
        }

        private void HandleInput()
        {
            _mouseDeltaX = Input.GetAxis("Mouse X");
        }
    }
}