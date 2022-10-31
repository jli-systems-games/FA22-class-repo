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
            }

            if (player2.gameObject.name == "Floor")
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                playerCollider.enabled = false;
            }
            
            if (player2.gameObject.name == "Exit_floor")
            {
                
                SceneManager.LoadScene("Ekaterina.Balance.Win");

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
