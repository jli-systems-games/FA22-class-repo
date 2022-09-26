using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Simon.Project2.Scripts
{
    public class GameManager : MonoBehaviour
    {
        
        public AudioSource theMusic;

        public bool startPlaying;

        public BeatScroller theBS;
        
        public static GameManager instance;

        public int currentScore;
        public int scorePerNote = 100;
        public int scorePerGoodNote = 125;
        public int scorePerPerfectNote = 150;

        public int currentMultiplier;
        public int multiplierTracker;
        public int[] multiplierThresholds;

        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI multiText;
        
        //retrieves the note holder to set it active upon game start
        public GameObject noteHolder;
        void Start()
        {
            instance = this;
            currentMultiplier = 1;
        }

        void Update()
        {
            if (!startPlaying)
            {
                if (Input.anyKeyDown)
                {
                    startPlaying = true;
                    theBS.hasStarted = true;
                    noteHolder.SetActive(true);
                    theMusic.Play();
                }
            }
        }

        public void NoteHit()
        {
           // Debug.Log("Hit on time");

            if (currentMultiplier - 1 < multiplierThresholds.Length)
            {
                multiplierTracker++;

                if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
                {
                    multiplierTracker = 0;
                    currentMultiplier++;
                }   
            }

            multiText.text = "x" + currentMultiplier;
            
            //currentScore += scorePerNote * currentMultiplier;
            scoreText.text = "Score: " + currentScore;
        }

        public void NormalHit()
        {
            currentScore += scorePerNote * currentMultiplier;
            NoteHit();
        }

        public void GoodHit()
        {
            currentScore += scorePerGoodNote * currentMultiplier;
            NoteHit();
        }

        public void PerfectHit()
        {
            currentScore += scorePerPerfectNote * currentMultiplier;
            NoteHit();
        }
        
        public void NoteMissed()
        {
            Debug.Log("Missed note");

            currentMultiplier = 1;
            multiplierTracker = 0;
            multiText.text = "x" + currentMultiplier;
        }
        
    }

}

