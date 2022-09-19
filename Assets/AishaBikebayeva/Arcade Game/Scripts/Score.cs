using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

namespace Aisha
{
    public class Score : MonoBehaviour
    {
        public TextMesh scoreText; 

        //public Sprite explosion;
        //private SpriteRenderer sr;

        //private variables have to be set in code
        public int score;
    

        //Start is called at game start, sets the score to 0
        void Start()
        {
            float score = 0;
        }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = "Score: " + score; 
            //score += Time.deltaTime;                                         
            score += 1;                                                             
                                                                      
        }

        // public void StoneHit()
        // {
        //     Debug.Log("player died"); //Print a useful message in the debug console
        //     score -= 0;
            
        // }

        // public void StoneMissed()
        // {
        //     Debug.Log("player is doing well"); //Print a useful message in the debug console
        //     score += 1;
        // }
    }
}