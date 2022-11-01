using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioBalance
{

    public class Laser2 : MonoBehaviour
    {
        public Camera cam;
        public SpriteRenderer sprite;
        public Transform firePoint;
        public BoxCollider2D boxCollider;

        private bool canShoot;

        // Start is called before the first frame update
        void Start()
        {
            canShoot = true;
            DisableLaser();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire2") && canShoot == true)
            {
                EnableLaser();
                canShoot = false;
                StartCoroutine(ShootCooldown(2f));
            }

            if (Input.GetButton("Fire2"))
            {
                UpdateLaser();
            }

            if (Input.GetButtonUp("Fire2"))
            {
                DisableLaser();
            }
        }

        private IEnumerator ShootCooldown(float cooldown)
        {
            //Cooldown
            // Everything Here Happens BEFORE Our Wait
            canShoot = false;

            yield return new WaitForSeconds(cooldown);
            //Can Shoot Again
            canShoot = true;
        }

        void EnableLaser()
        {
            boxCollider.enabled = true;
            sprite.enabled = true;
        }

        void UpdateLaser()
        {

        }

        void DisableLaser()
        {
            boxCollider.enabled = false;
            sprite.enabled = false;
        }
    }
}