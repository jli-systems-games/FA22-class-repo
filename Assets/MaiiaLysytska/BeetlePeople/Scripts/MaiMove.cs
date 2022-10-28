using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Bananagodzilla
{


    public class MaiMove : MonoBehaviour
    {


        public List<KeyCode> keycodes;
        public float speed;
        public Rigidbody2D rb;
        public Animator anim;
        public AudioSource audioSource;
        public bool IsMoving = false;

        private void Start()
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
            anim = gameObject.GetComponent<Animator>();
        }

        private void Update()
        {


            if (IsMoving)
            {
                if (Input.GetKey(keycodes[0]))
                {


                    rb.velocity = new Vector2(speed, 0);

                    if (!audioSource.isPlaying)
                    {
                        audioSource.Play(0);
                    }

                }



                else if (Input.GetKey(keycodes[1]))
                {


                    rb.velocity = new Vector2(-speed, 0);
                    
                    if (!audioSource.isPlaying)
                    {
                        audioSource.Play(0);
                    }

                }  else
                    audioSource.Stop();

            }

        }


    



public void IfMoves()
        {
            if (IsMoving)
            {
                IsMoving = false;
            }

            if (!IsMoving)
            {
                IsMoving = true;
            }
        }
    }
}
    
    

