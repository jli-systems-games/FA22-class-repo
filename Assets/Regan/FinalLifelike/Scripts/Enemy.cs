using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace ReganLifeLike {
    public class Enemy : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private int damage = 3;
        [SerializeField]
        private int maxHealth = 10;
        public int health = 10;
        [SerializeField]
        private float _movementSpeed = 5;
        [SerializeField]
        private float _detectionRange = 5;
        [SerializeField]
        private LayerMask _raycastMask;
        [SerializeField]
        private float _shootDistance;

        [SerializeField]
        private Animator _animator;
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        
        [SerializeField]
        private GameObject _meatPrefab;
        [SerializeField]
        private GameObject _bulletPrefab;

        private Vector2 _movement = new Vector2();
        private int _direction = 0;


        private bool _shootCooldown = false;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        public void Damage(int amount)
        {
            health -= amount;

            if (health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            GameObject meatObject = Instantiate(_meatPrefab);
            meatObject.transform.position = transform.position;

            Destroy(gameObject);
        }

        private void Update()
        {
            HandleBehaviour();
            HandleMovement();
        }

        private void MoveTowards(Vector2 target)
        {
    

            if (target.x > transform.position.x)
            {
                _direction = 1;
                _movement.x += 1;
            }else
            if (target.x < transform.position.x)
            {
                _direction = 0;
                _movement.x -= 1;
            }
        }

        private bool TryShoot(Vector2 target)
        {
            if (Mathf.Abs(target.x - transform.position.x) > _shootDistance) return false;

            if (Mathf.Abs(target.y - transform.position.y) > 1) return false;

            if (_shootCooldown) return true;

            Shoot();

            return true;
        }

        private async void Shoot()
        {
            _shootCooldown = true;

            _animator.Play("shoot");

            GameObject bulletObject = Instantiate(_bulletPrefab);
            bulletObject.transform.position = transform.position;
            bulletObject.GetComponent<Bullet>().startVelocity = _direction != 0 ? new Vector3(10, 0, 0) : new Vector3(-10, 0, 0);

            await Task.Delay(1500);

            _shootCooldown = false;
        }

        private void HandleBehaviour()
        {
            Player targetPlayer = GetPlayerInRange();

            if (!targetPlayer)
            {
                return;
            }

            if (TryShoot(targetPlayer.transform.position)) return;

            MoveTowards(targetPlayer.transform.position);

        }

        private void HandleMovement()
        {
            Vector2 velocity = _rigidbody.velocity;
            velocity.x = _movement.x * _movementSpeed;
            _rigidbody.velocity = velocity;

            _animator.SetFloat("Speed", Mathf.Abs(_movement.x));

            _spriteRenderer.flipX = _direction != 1;

            _movement = new Vector2();
        }

        private Player GetPlayerInRange()
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, _detectionRange, 1 << 26);
            
            if (collider == null) return null;
            Debug.Log("player in range" + ( collider.transform.position - transform.position ).normalized.ToString());
            RaycastHit2D hit = Physics2D.Raycast(transform.position, (collider.transform.position - transform.position).normalized, _detectionRange, _raycastMask);
            
            if (hit.collider)
            {
                if (hit.collider.gameObject.layer == 3) return null;
            }

            Player player = collider.GetComponent<Player>();

            if (player == null) return null;

            return player;
        }

    }
}

