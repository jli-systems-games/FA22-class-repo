using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelBalance
{
    public class StartCart : MonoBehaviour
    {
        private bool isOnS1;
        private bool isOnS2;
        private bool canMove;
        private bool moving;

        public Transform st1;
        public Transform st2;

        public float speed = 5f;

        public GameObject[] keyInstructions;

        // Start is called before the first frame update
        void Start()
        {
            isOnS1 = true;
            isOnS2 = false;
            canMove = false;
            moving = false;
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(isOnS1);
           

                if (canMove)
            {
                if (Input.GetKeyDown("f"))
                {

                    moving = true;
                }
            }

            if (moving)
            {
                startMoving();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                canMove = true;
                for (int i = 0; i < keyInstructions.Length; i++)
                {
                    keyInstructions[i].SetActive(true);
                }
            }
            

        }

        private void OnTriggerExit(Collider other)
        {
            canMove = false;
            for (int i = 0; i < keyInstructions.Length; i++)
            {
                keyInstructions[i].SetActive(false);
            }
        }

        private void startMoving()
        {
            if (moving)
            {
                StartCoroutine(startMove());
            }
            
        }
        IEnumerator startMove()
        {
            yield return new WaitForSeconds(2);
            
            if (isOnS1&&moving)
            {
                transform.position = Vector3.MoveTowards(transform.position, st2.position, Time.deltaTime*speed);
                if (transform.position == st2.position)
                {
                    isOnS1 = false;
                    moving = false;
                    isOnS2 = true;
                }
            }
            else if (isOnS2&&moving)
            {
                transform.position = Vector3.MoveTowards(transform.position, st1.position, Time.deltaTime * speed);
                if (transform.position == st1.position)
                {
                    isOnS2 = false;
                    moving = false;
                    isOnS1 = true;

                }
            }

        }

    }

}
