using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioBalance
{
    public class CoroutineDemo : MonoBehaviour
    {
        private bool canShoot;


        // Start is called before the first frame update
        void Start()
        {
            canShoot = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && canShoot == true)
            {
                //Shoot
                Debug.Log("Bang.");
                canShoot = false;
                StartCoroutine(ShootCooldown(2f));
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
    }
}