using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioArcadeSoccer
{
    public class ResetBall : MonoBehaviour
    {

        Vector3 originalPos;
        // Start is called before the first frame update
        void Start()
        {
            originalPos = gameObject.transform.position;
        }

        void LateUpdate()
        {
            if (hasStopped)
            {
                hasStopped = false;
                var rigidbody2D = this.GetComponent<Rigidbody2D>();

                if (rigidbody2D)
                {
                    rigidbody2D.isKinematic = true;
                    rigidbody2D.isKinematic = false;
                }
            }
        }

        bool hasStopped;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Goal")
            {
                gameObject.transform.position = originalPos;

                var rigidbody2D = this.GetComponent<Rigidbody2D>();
                if (rigidbody2D)
                {
                    rigidbody2D.isKinematic = false;

                    // Reset the velocity
                    rigidbody2D.velocity = Vector3.zero;
                    hasStopped = true;
                }
            }
        }
    }
}