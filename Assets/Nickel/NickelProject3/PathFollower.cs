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

        // Start is called before the first frame update
        void Start()
        {
            transform.position = waypoints[waypointIndex].transform.position;
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
                transform.position = Vector2.MoveTowards(transform.position,
                    waypoints[waypointIndex].transform.position,
                    moveSpeed);

                if (transform.position == waypoints[waypointIndex].transform.position)
                {
                    waypointIndex += 1;
                }
            }

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
