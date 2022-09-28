using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WeiGame
{
    public class WeiFirePoint3 : MonoBehaviour
    {

        public GameObject firePoint;
        public GameObject bullet;


        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(FireShotgun(firePoint.transform.position));
        }

        IEnumerator FireShotgun(Vector3 firePosition)
        {
            float rotationAngle = 0f;
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    rotationAngle += 20f;
                    CreatBullet(rotationAngle, firePosition);

                }
                yield return new WaitForSeconds(2f);
            }
        }

        private void CreatBullet(float rotationAngle, Vector3 firePosition)
        {
            Instantiate(bullet, firePosition, Quaternion.AngleAxis(rotationAngle, Vector3.forward));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}