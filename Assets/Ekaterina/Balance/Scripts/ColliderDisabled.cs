using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
    public class ColliderDisabled : MonoBehaviour
    {
        public TrailRenderer trail;
        public ParticleSystemRenderer particles;
        public BoxCollider2D objectA;
        public BoxCollider2D exit;
        
        BoxCollider2D player;

        private void Awake()
        {
            exit.enabled = false;
        }

        void OnCollisionEnter2D(Collision2D player)
        {

            if (player.gameObject.name == "Object B")
            {
                objectA.enabled = false;
                Debug.Log("Collision!");

            }
            
            if (player.gameObject.name == "Exit_floor")
            {
                Debug.Log("Collision2!");
                
                exit.enabled = true;
                
                gameObject.GetComponent<Renderer> ().material.color = Color.black;
                trail.GetComponent<TrailRenderer> ().enabled = false;
                particles.GetComponent<ParticleSystemRenderer> ().enabled = false;

            }



        }
    }
}


