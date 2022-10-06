using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioGrowth
{

    public class Mover : MonoBehaviour
    {
        public float circuitCompleteTime;
        public float min;
        public float max;
        public Vector2 direction;
        public Vector2 startingPos;
        // Start is called before the first frame update
        void Start()
        {
            startingPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            MovePlatform();
        }

        private void MovePlatform()
        {
            float newPosition = Mathf.SmoothStep(0, circuitCompleteTime, Mathf.PingPong(Time.time / circuitCompleteTime, 1));
            float clampedPosition = Scale(newPosition, 0, circuitCompleteTime, min, max);
            transform.position = new Vector2(startingPos.x + (clampedPosition * direction.x), startingPos.y + (clampedPosition * direction.y));
        }

        private void OnDrawGizmos()
        {
            if (Application.isPlaying == false)
            {
                Vector2 startPointMin = new Vector2(transform.position.x + (min * direction.x), transform.position.y + (min * direction.y));
                Vector2 startPointMax = new Vector2(transform.position.x + (max * direction.x), transform.position.y + (max * direction.y));
                Gizmos.DrawLine(startPointMin, startPointMax);
            }
            else
            {
                Vector2 startPointMin = new Vector2(startingPos.x + (min * direction.x), startingPos.y + (min * direction.y));
                Vector2 startPointMax = new Vector2(startingPos.x + (max * direction.x), startingPos.y + (max * direction.y));
                Gizmos.DrawLine(startPointMin, startPointMax);
            }
        }

        private float Scale(float oldValue, float oldMin, float oldMax, float newMin, float newMax)
        {
            float oldRange = oldMax - oldMin;
            float newRange = newMax - newMin;
            float newValue = (((oldValue - oldMin) * newRange) / oldRange) + newMin;
            return (newValue);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.CompareTag("Player"))
            {
                collision.transform.SetParent(transform);
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.transform.CompareTag("Player"))
            {
                transform.DetachChildren();
            }
        }
    }
}