using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioBalance
{

    public class StrongLaser : MonoBehaviour
    {
        public Camera cam;
        public SpriteRenderer sprite1;
        public SpriteRenderer sprite2;
        public SpriteRenderer sprite3;
        public SpriteRenderer sprite4;
        public Transform firePoint;
        public BoxCollider2D boxCollider1;
        public BoxCollider2D boxCollider2;
        public BoxCollider2D boxCollider3;
        public BoxCollider2D boxCollider4;

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
            if (Input.GetButtonDown("Fire3") && canShoot == true)
            {
                EnableLaser();
                canShoot = false;
                StartCoroutine(ShootCooldown(2f));
            }

            if (Input.GetButton("Fire3"))
            {
                UpdateLaser();
            }

            if (Input.GetButtonUp("Fire3"))
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
            boxCollider1.enabled = true;
            boxCollider2.enabled = true;
            boxCollider3.enabled = true;
            boxCollider4.enabled = true;
            sprite1.enabled = true;
            sprite2.enabled = true;
            sprite3.enabled = true;
            sprite4.enabled = true;
        }

        void UpdateLaser()
        {

        }

        void DisableLaser()
        {
            boxCollider1.enabled = false;
            boxCollider2.enabled = false;
            boxCollider3.enabled = false;
            boxCollider4.enabled = false;
            sprite1.enabled = false;
            sprite2.enabled = false;
            sprite3.enabled = false;
            sprite4.enabled = false;
        }
    }
}