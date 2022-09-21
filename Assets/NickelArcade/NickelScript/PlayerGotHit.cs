using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NickelArcade
{
    public class PlayerGotHit : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject stunned;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        //private void OnTriggerEnter2D(Collider2D collision)
        //{
        //    if (collision.gameObject.CompareTag("bullet"))
        //    {
        //        Debug.Log("Hit!");
        //        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        //        StartCoroutine(Stuntime());
        //    }
        //}
        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.CompareTag("bullet"))
            {
                Debug.Log("Hit!");
                stunned.SetActive(true);
                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                StartCoroutine(Stuntime());

            }
        }


        IEnumerator Stuntime()
        {

            yield return new WaitForSeconds(2);
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            stunned.SetActive(false);


        }


    }
}


