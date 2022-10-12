using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class FlowerShoot : MonoBehaviour
    {
        // Start is called before the first frame update
        public Transform firePoint;
        public GameObject bulletPrefeb;

        private bool shoot = false;

        public float FireRate = 1;
        private float time;
        private float nextTimeFire;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(shoot);
            if (shoot)
            {
                time += Time.deltaTime;
                nextTimeFire = 1 / FireRate;
                if (time >= nextTimeFire)
                {
                    Instantiate(bulletPrefeb, firePoint.position, Quaternion.identity);
                    time = 0;
                }
            }



        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                shoot = true;
            }

        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                shoot = false;
            }

        }


    }

}

