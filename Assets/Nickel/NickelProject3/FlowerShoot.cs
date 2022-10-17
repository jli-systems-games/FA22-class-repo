using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class FlowerShoot : MonoBehaviour
    {
        // Start is called before the first frame update
        //public Transform firePoint;
        //public GameObject bulletPrefeb;

        //private bool shoot = false;

        //public float FireRate = 1;
        //private float time;
        //private float nextTimeFire;
        //void Start()
        //{

        //}

        //// Update is called once per frame
        //void Update()
        //{
        //    //Debug.Log(shoot);
        //    if (shoot)
        //    {
        //        time += Time.deltaTime;
        //        nextTimeFire = 1 / FireRate;
        //        if (time >= nextTimeFire)
        //        {
        //            Instantiate(bulletPrefeb, firePoint.position, Quaternion.identity);
        //            time = 0;
        //        }
        //    }



        //}

        //private void OnTriggerEnter2D(Collider2D collision)
        //{
        //    if (collision.CompareTag("Enemy"))
        //    {
        //        shoot = true;
        //    }

        //}

        //private void OnTriggerExit2D(Collider2D collision)
        //{
        //    if (collision.CompareTag("Enemy"))
        //    {
        //        shoot = false;
        //    }

        //}

        private Transform target;
        private PathFollower targetEnemy;

        public float range = 2.35f;
        public GameObject bulletPrefab;
        public float fireRate = 0.7f;
        private float fireCountdown = 0f;

        public string enemyTag = "Enemy";

        public Transform partToRotate;
        public float turnSpeed = 10f;
        public Transform firePoint;

        private void Start()
        {
            InvokeRepeating("UpdateTarget", 0f, 0.5f);
        }

        void UpdateTarget()
        {
            
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
            float shortestDitance = 3.2f;
            GameObject nearestEnemy = null;
            foreach(GameObject enemy in enemies)
            {
                float distanceToenemy = Vector3.Distance(transform.position, enemy.transform.position);
                //Debug.Log(distanceToenemy);
                if (distanceToenemy < shortestDitance)
                {
                    shortestDitance = distanceToenemy;
                    nearestEnemy = enemy;
                    
                }
            }

            if(nearestEnemy !=null && shortestDitance <= range)
            {
                target = nearestEnemy.transform;
                targetEnemy = nearestEnemy.GetComponent<PathFollower>();
            }
            else
            {
                target = null;
            }
            
        }

        private void Update()
        {
            
            LockOnTarget();

            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }

            fireCountdown -= Time.deltaTime;

            if (target == null)
            {
                return;
            }

        }

        void LockOnTarget()
        {
            if (target != null)
            {
                Vector3 dir = target.position - transform.position;
                Quaternion lookRotation = Quaternion.LookRotation(dir);
                Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
                partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
            }
            
        }

        void Shoot()
        {
            if (target != null)
            {
                
                GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                bullet _bullet = bulletGO.GetComponent<bullet>();

                if (_bullet != null)
                {
                    _bullet.Seek(target);
                }
            }
            
           
        }




    }

}

