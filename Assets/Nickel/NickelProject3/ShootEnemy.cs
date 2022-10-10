using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class EnemyMoveToward : MonoBehaviour
    {
        private float speed = 2f;
        public GameObject target;
        private Vector2 targetPosition;
        private Vector2 position;

        // Start is called before the first frame update
        void Start()
        {
            targetPosition = target.GetComponent<Transform>().position;
            position = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}

