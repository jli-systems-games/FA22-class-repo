using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
    
    public class ExitSoundController2 : MonoBehaviour
    {
        private AudioSource exitSound;
        private BoxCollider2D exitFloor;
        
        // Start is called before the first frame update
        void Start()
        {
            exitSound = GetComponent<AudioSource>();
        }

        void OnCollisionEnter2D(Collision2D exitFloor)
        {
            if (exitFloor.gameObject.name == "Player2")
            {
                exitSound.Play();
            }
        }
    }
}
