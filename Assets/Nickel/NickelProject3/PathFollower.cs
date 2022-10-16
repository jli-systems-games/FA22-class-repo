using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class PathFollower : MonoBehaviour
    {
        [SerializeField]
        public Transform[] waypoints;

        [SerializeField]
        public static float moveSpeed = 10f;

        private int waypointIndex = 0;

        private int damage = 0;
        private float movementTime;

        // Start is called before the first frame update
        void Start()
        {
            if (waypoints.Length != 0)
            {
                transform.position = waypoints[waypointIndex].transform.position;

            }
            movementTime = 0f;
            MoveForSeconds(3f);

        }

        // Update is called once per frame
        void Update()
        {

            Move();
        }

        private void Move()
        {
            if (waypointIndex <= waypoints.Length - 1)
            {
                if (Time.time < 1f)
                {
                    Vector2 direction = Vector2.MoveTowards(transform.position,
                   waypoints[waypointIndex].transform.position,
                   moveSpeed);
                    direction -= (Vector2)transform.position;
                    transform.GetComponent<Rigidbody2D>().velocity = direction;
                }
                

                if (transform.position == waypoints[waypointIndex].transform.position)
                {
                    waypointIndex += 1;
                }
            }


        }

        void MoveForSecond(float second)
        {
            movementTime = Time.time + second;
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("bullet"))
            {
                Destroy(collision.gameObject);
                damage++;
            }
            
        }

    }

}
