using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioBalance
{

    public class Laser : MonoBehaviour
    {
        public Camera cam;
        public SpriteRenderer sprite;
        public Transform firePoint;

        // Start is called before the first frame update
        void Start()
        {
            DisableLaser();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                EnableLaser();
            }

            if (Input.GetButton("Fire1"))
            {
                UpdateLaser();
            }

            if (Input.GetButtonUp("Fire1"))
            {
                DisableLaser();
            }
        }

        void EnableLaser()
        {
            sprite.enabled = true;
        }

        void UpdateLaser()
        {

        }

        void DisableLaser()
        {
            sprite.enabled = false;
        }
    }
}