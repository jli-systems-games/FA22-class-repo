using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Regan {

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private Collider2D _feetCollider;

    [SerializeField]
    private float _movementSpeed = 20;

    private Rigidbody2D _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleInput();
    }


    private void HandleInput()
    {
        Vector2 movementInput = new();

        if (Input.GetKey(KeyCode.D))
        {
            movementInput.x += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementInput.x -= 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        Move(movementInput);
    }

    private void Jump()
    {
        if (!_feetCollider.IsTouchingLayers(1<<3)) return;

        Vector2 velocity = _rigidbody.velocity;
        velocity.y += 10;
        _rigidbody.velocity = velocity;
    }

    private void Move(Vector2 movementVector)
    {
        Vector2 velocity = _rigidbody.velocity;
        velocity.x = movementVector.x * _movementSpeed;
        _rigidbody.velocity = velocity;
    }

}
}
