using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
    public class CollisionManager : MonoBehaviour
    {
        public TrailRenderer trail;
        public ParticleSystemRenderer particles;
        
        public BoxCollider2D block23;
        public BoxCollider2D block24;
        public BoxCollider2D block25;
        
        public BoxCollider2D block26;
        public BoxCollider2D block29;
        public BoxCollider2D block30;
        
        public BoxCollider2D block31;
        public BoxCollider2D block32;
        public BoxCollider2D block33;
        public BoxCollider2D block34;
        public BoxCollider2D block35;
        
        public BoxCollider2D block36;
        public BoxCollider2D block37;
        public BoxCollider2D block38;
        
        public BoxCollider2D block43;
        public BoxCollider2D block44;
        public BoxCollider2D block45;
        
        public BoxCollider2D block46;
        public BoxCollider2D block47;
        public BoxCollider2D block48;
        public BoxCollider2D block49;
        public BoxCollider2D block50;
        
        public BoxCollider2D block51;
        public BoxCollider2D block52;
        public BoxCollider2D block53;
        public BoxCollider2D block54;
        public BoxCollider2D block55;
        
        public BoxCollider2D block56;
        public BoxCollider2D block57;
        public BoxCollider2D block58;
        public BoxCollider2D block59;

        public BoxCollider2D exit_top;
        public BoxCollider2D exit_left;
        public BoxCollider2D exit_right;
        
        BoxCollider2D player;
        
        public Rigidbody2D player2;

        private void Awake()
        {
            exit_top.enabled = false;
            exit_left.enabled = false;
            exit_right.enabled = false;
        }

        void OnCollisionEnter2D(Collision2D player)
        {

            if (player.gameObject.name == "Enemy_1" || player.gameObject.name == "Enemy_2" || player.gameObject.name == "Enemy_3")
            {
                block23.enabled = false;
                block24.enabled = false;
                block25.enabled = false;
                
                block26.enabled = false;
                block29.enabled = false;
                block30.enabled = false;
                
                block31.enabled = false;
                block32.enabled = false;
                block33.enabled = false;
                block34.enabled = false;
                block35.enabled = false;
                
                block36.enabled = false;
                block37.enabled = false;
                block38.enabled = false;
                
                block43.enabled = false;
                block44.enabled = false;
                block45.enabled = false;
                
                block46.enabled = false;
                block47.enabled = false;
                block48.enabled = false;
                block49.enabled = false;
                block50.enabled = false;
                
                block51.enabled = false;
                block52.enabled = false;
                block53.enabled = false;
                block54.enabled = false;
                block55.enabled = false;
                
                block56.enabled = false;
                block57.enabled = false;
                block58.enabled = false;
                block59.enabled = false;
            }
            
            if (player.gameObject.name == "Floor")
            {
                block23.enabled = true;
                block24.enabled = true;
                block25.enabled = true;
                
                block26.enabled = true;
                block29.enabled = true;
                block30.enabled = true;
                
                block31.enabled = true;
                block32.enabled = true;
                block33.enabled = true;
                block34.enabled = true;
                block35.enabled = true;
                
                block36.enabled = true;
                block37.enabled = true;
                block38.enabled = true;
                
                block43.enabled = true;
                block44.enabled = true;
                block45.enabled = true;
                
                block46.enabled = true;
                block47.enabled = true;
                block48.enabled = true;
                block49.enabled = true;
                block50.enabled = true;
                
                block51.enabled = true;
                block52.enabled = true;
                block53.enabled = true;
                block54.enabled = true;
                block55.enabled = true;
                
                block56.enabled = true;
                block57.enabled = true;
                block58.enabled = true;
                block59.enabled = true;
            }
            
            if (player.gameObject.name == "Exit_floor")
            {
                player2.constraints = RigidbodyConstraints2D.None;

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


