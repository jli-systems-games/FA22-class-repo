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

        // Start is called before the first frame update
        void Start()
        {
            DisableLaser();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire2"))
            {
                EnableLaser();
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