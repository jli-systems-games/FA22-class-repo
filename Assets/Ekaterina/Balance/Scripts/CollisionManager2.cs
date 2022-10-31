using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina
{
    public class CollisionManager2 : MonoBehaviour
    {
        public TrailRenderer trail;
        public ParticleSystemRenderer particles;
        
        BoxCollider2D player2;
        public Rigidbody2D player;
        public BoxCollider2D playerCollider;

        
        public BoxCollider2D exit_top;
        public BoxCollider2D exit_left;
        public BoxCollider2D exit_right;
        
        public BoxCollider2D block1;
        public BoxCollider2D block2;
        public BoxCollider2D block3;
        public BoxCollider2D block4;
        public BoxCollider2D block5;
        
        public BoxCollider2D block6;
        public BoxCollider2D block7;
        public BoxCollider2D block8;
        public BoxCollider2D block9;
        public BoxCollider2D block10;
        
        public BoxCollider2D block11;
        public BoxCollider2D block12;
        public BoxCollider2D block13;
        public BoxCollider2D block14;
        public BoxCollider2D block15;
        
        public BoxCollider2D block16;
        public BoxCollider2D block17;
        public BoxCollider2D block18;
        public BoxCollider2D block19;
        public BoxCollider2D block20;
        
        public BoxCollider2D block21;
        public BoxCollider2D block22;
        public BoxCollider2D block23;
        public BoxCollider2D block24;
        public BoxCollider2D block25;
        
        public BoxCollider2D block26;
        public BoxCollider2D block27;
        public BoxCollider2D block28;
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
        public BoxCollider2D block39;
        public BoxCollider2D block40;
        
        public BoxCollider2D block41;
        public BoxCollider2D block42;

        private void Awake()
        {
            exit_top.enabled = false;
            exit_left.enabled = false;
            exit_right.enabled = false;
        }

        void OnCollisionEnter2D(Collision2D player2)
        {
            if (player2.gameObject.name == "Enemy_1" || player2.gameObject.name == "Enemy_2" ||
                player2.gameObject.name == "Enemy_3")
            {
                Physics2D.gravity = new Vector2(0, 9.8f);
                
                    block1.enabled = false;
                    block2.enabled = false;
                    block3.enabled = false;
                    block4.enabled = false;
                    block5.enabled = false;
                
                    block6.enabled = false;
                    block7.enabled = false;
                    block8.enabled = false;
                    block9.enabled = false;
                    block10.enabled = false;
                
                    block11.enabled = false;
                    block12.enabled = false;
                    block13.enabled = false;
                    block14.enabled = false;
                    block15.enabled = false;
                    
                    block16.enabled = false;
                    block17.enabled = false;
                    block18.enabled = false;
                    block19.enabled = false;
                    block20.enabled = false;
                    
                    block21.enabled = false;
                    block22.enabled = false;
                    block23.enabled = false;
                    block24.enabled = false;
                    block25.enabled = false;
                    
                    block26.enabled = false;
                    block27.enabled = false;
                    block28.enabled = false;
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
                    block39.enabled = false;
                    block40.enabled = false;
                    
                    block41.enabled = false;
                    block42.enabled = false;
            }

            if (player2.gameObject.name == "Block 2")
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                playerCollider.enabled = false;
            }

            if (player2.gameObject.name == "Ceiling")
            {
                Physics2D.gravity = new Vector2(0, -9.8f);
                
                block1.enabled = true;
                block2.enabled = true;
                block3.enabled = true;
                block4.enabled = true;
                block5.enabled = true;

                block6.enabled = true;
                block7.enabled = true;
                block8.enabled = true;
                block9.enabled = true;
                block10.enabled = true;

                block11.enabled = true;
                block12.enabled = true;
                block13.enabled = true;
                block14.enabled = true;
                block15.enabled = true;
                
                block16.enabled = true;
                block17.enabled = true;
                block18.enabled = true;
                block19.enabled = true;
                block20.enabled = true;
                
                block21.enabled = true;
                block22.enabled = true;
                block23.enabled = true;
                block24.enabled = true;
                block25.enabled = true;
                
                block26.enabled = true;
                block27.enabled = true;
                block28.enabled = true;
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
                block39.enabled = true;
                block40.enabled = true;
                
                block41.enabled = true;
                block42.enabled = true;
            }

            if (player2.gameObject.name == "Exit_floor")
            {
                exit_top.enabled = true;
                exit_left.enabled = true;
                exit_right.enabled = true;
                
                gameObject.GetComponent<Renderer> ().material.color = Color.black;
                trail.GetComponent<TrailRenderer> ().enabled = false;
                particles.GetComponent<ParticleSystemRenderer> ().enabled = false;
            }
            
            if (player2.gameObject.name == "Exit_right")
            {
                SceneManager.LoadScene("Ekaterina.Balance.Win");
            }
        }
    }
}
