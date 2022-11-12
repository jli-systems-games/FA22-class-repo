using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using TMPro;

namespace AishasCircus
{
    public class CircusScore : MonoBehaviour
    {
        public TMP_Text scoreText; 
        public GameObject gameOverScene;
        //public Sprite explosion;
        //private SpriteRenderer sr;

        //private variables have to be set in code
        public static float score;
    

        //Start is called at game start, sets the score to 0
        void Start()
        {
            score = 0;

        }

        // Update is called once per frame
        void Update()
        {
            if (!gameOverScene.activeSelf){
                scoreText.text = "Score: " + score; 
                //score += Time.deltaTime;                                         
                score += 1;                                                             
            }                                                        
        }
    }
}