using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace nickelLifelike
{
    public class bullet : MonoBehaviour
    {
        private Rigidbody2D rb;
        // Start is called before the first frame update
        private GameObject enemy;

        private Transform target;

        public float bulletSpeed = 1;



        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            
            rb = transform.GetComponent<Rigidbody2D>();
            Vector2 direction = Vector2.MoveTowards(transform.position, target.transform.position, bulletSpeed);
            direction -= (Vector2)transform.position;
            rb.velocity = direction * 5;

        }

        public void Seek(Transform _target)
        {
            target = _target;
            Debug.Log(target);
        }
    }

}

