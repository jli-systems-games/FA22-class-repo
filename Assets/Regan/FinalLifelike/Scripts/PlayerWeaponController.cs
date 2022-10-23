using ReganLifeLike;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace ReganLifeLike
{
    public class PlayerWeaponController : MonoBehaviour
    {
        [SerializeField]
        private Animator _animator;
        [SerializeField]
        private Transform _meleePoint;
        private float _meleeRadius = 1;
        private int _meleeStrength = 1;
        private int _meleeCooldownMiliseconds = 500;

        private int _currentWeapon = 0;
        private bool _meleeCooldown = false;

        [HideInInspector]
        public bool active = true;

        private void Update()
        {
            if (!active) return;
            HandleInput();
        }

        private void HandleInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }
        }

        private async void Attack()
        {
            if (_meleeCooldown) return;

            _meleeCooldown = true;

            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(_meleePoint.position, _meleeRadius, 1 << 28);

            foreach (Collider2D hitCollider in hitColliders)
            {
                hitCollider.GetComponent<Enemy>().Damage(_meleeStrength);
            }

            _animator.Play("punch");

            await Task.Delay(_meleeCooldownMiliseconds);

            _meleeCooldown = false;
        }
    }
}