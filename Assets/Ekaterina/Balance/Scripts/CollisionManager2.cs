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
        public BoxCollider2D block60;
        
        public BoxCollider2D block61;
        public BoxCollider2D block62;
        public BoxCollider2D block63;
        public BoxCollider2D block64;
        public BoxCollider2D block65;

        public BoxCollider2D block66;
        public BoxCollider2D block67;
        public BoxCollider2D block68;
        public BoxCollider2D block69;
        public BoxCollider2D block70;
        public BoxCollider2D block71;
        
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
                    block60.enabled = false;
                    
                    block61.enabled = false;
                    block62.enabled = false;
                    block63.enabled = false;
                    block64.enabled = false;
                    block65.enabled = false;
                    
                    block66.enabled = false;
                    block67.enabled = false;
                    block68.enabled = false;
                    block69.enabled = false;
                    block70.enabled = false;
                    block71.enabled = false;

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
                block60.enabled = true;
                
                block61.enabled = true;
                block62.enabled = true;
                block63.enabled = true;
                block64.enabled = true;
                block65.enabled = true;

                block66.enabled = true;
                block67.enabled = true;
                block68.enabled = true;
                block69.enabled = true;
                block70.enabled = true;

                block71.enabled = true;
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
