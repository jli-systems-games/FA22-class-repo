using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


namespace ReganLifeLike
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        private Collider2D _feetCollider;
        [SerializeField]
        private Animator _animator;
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        [SerializeField]
        private float _movementSpeed = 20;
        [SerializeField]
        private float _jumpStrength = 20;


        private Rigidbody2D _rigidbody;

        private bool _justJumped = false;
        private bool _isOnGround = false;

        [HideInInspector]
        public bool active = true;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {

            HandleInput();
            HandleJumpGravity();
        }

        private void HandleInput()
        {
            Vector2 movementInput = new();

            if (!active)
            {
                movementInput = new();
                _animator.SetBool("IsFalling", !_isOnGround);
                _animator.SetFloat("Speed", Mathf.Abs(movementInput.x));
                Move(movementInput);
                return;
            }

            _isOnGround = _feetCollider.IsTouchingLayers(1 << 3);

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

            _animator.SetFloat("Speed", Mathf.Abs(movementInput.x));

            if (movementInput.x > 0)
            {
                _spriteRenderer.flipX = false;
            }else if(movementInput.x < 0)
            {
                _spriteRenderer.flipX = true;
            }

            _animator.SetBool("IsFalling", !_isOnGround);

            
            

            Move(movementInput);
        }

        private void Jump()
        {
            if (!_isOnGround) return;

            Vector2 velocity = _rigidbody.velocity;
            velocity.y += _jumpStrength;
            _rigidbody.velocity = velocity;
            _justJumped = true;
        }
        private void HandleJumpGravity()
        {
            if (!Input.GetKey(KeyCode.Space) || !_justJumped)
            {
                _rigidbody.gravityScale = 4f;
                _justJumped = false;
                return;
            }

            _rigidbody.gravityScale = 1f;
            return;
        }

        private void Move(Vector2 movementVector)
        {
            Vector2 velocity = _rigidbody.velocity;
            velocity.x = movementVector.x * _movementSpeed;
            _rigidbody.velocity = velocity;
        }

    }
}