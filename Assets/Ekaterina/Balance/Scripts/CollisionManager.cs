using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
    public class CollisionManager : MonoBehaviour
    {
        AudioSource winSound;
        
        public TrailRenderer trail;
        public ParticleSystemRenderer particles;
        
        public BoxCollider2D block1;
        public BoxCollider2D block2;
        public BoxCollider2D block3;
        public BoxCollider2D block4;
        public BoxCollider2D block5;

        public BoxCollider2D exit_top;
        public BoxCollider2D exit_left;
        public BoxCollider2D exit_right;
        
        BoxCollider2D player;
        
        public Rigidbody2D player2;
        
        private void Start()
        {
            winSound = GetComponent<AudioSource>();
        }

        private void Awake()
        {
            exit_top.enabled = false;
            exit_left.enabled = false;
            exit_right.enabled = false;
        }

        void OnCollisionEnter2D(Collision2D player)
        {

            if (player.gameObject.name == "Enemy_1")
            {
                block1.enabled = false;
                block2.enabled = false;
                block3.enabled = false;
                block4.enabled = false;
                block5.enabled = false;
            }
            
            if (player.gameObject.name == "Floor")
            {
                block1.enabled = true;
                block2.enabled = true;
                block3.enabled = true;
                block4.enabled = true;
                block5.enabled = true;
            }
            
            if (player.gameObject.name == "Exit_floor")
            {
                winSound.Play();
                    
                player2.constraints = RigidbodyConstraints2D.None;
                //player2.constraints = RigidbodyConstraints2D.FreezeAll;

                exit_top.enabled = true;
                exit_left.enabled = true;
                exit_right.enabled = true;
                
                gameObject.GetComponent<Renderer> ().material.color = Color.black;
                trail.GetComponent<TrailRenderer> ().enabled = false;
                particles.GetComponent<ParticleSystemRenderer> ().enabled = false;
            }
        }
    }
}


