using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Simon.Project2.Scripts;

namespace Simon.Project2.Scripts
{
    public class GameManager : MonoBehaviour
    {
        
        public AudioSource theMusic;

        public bool startPlaying;

        public BeatScroller theBS;
        public EnemyScroller theES;
        
        public static GameManager instance;

        public int currentScore;
        public int scorePerNote = 80;
        public int scorePerGoodNote = 120;
        public int scorePerPerfectNote = 150;

        public int maxScore = 70000;

        public int currentMultiplier;
        public int multiplierTracker;
        public int[] multiplierThresholds;

        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI multiText;
        
        //retrieves the note holder to set it active upon game start
        public GameObject noteHolder;
        public GameObject enemyHolder;
        
        //retrieves the start screen to set it inactive
        public GameObject startScreen;

        //retrieves the heel's parent game object
        public GameObject heelParent;
        

        public GameObject meshParent;
        void Start()
        {
            instance = this;
            currentMultiplier = 1;
        }

        void Update()
        {
            if (!startPlaying)
            {
                if (Input.GetKey("space") && Input.GetKey(KeyCode.RightShift))
                {
                    startPlaying = true;
                    theBS.hasStarted = true;
                    theES.hasStarted = true;
                    noteHolder.SetActive(true);
                    startScreen.SetActive(false);
                    theMusic.Play();
                }

                
            }

            float t = (float)currentScore / maxScore;
            //float n = 2;
            //t = (Mathf.Pow(n, t) - 1) / (n - 1);
            
            float heelScale = Mathf.Lerp(0.4f, 1.0f, t);
            
            heelParent.transform.localScale = new Vector3(heelScale, heelScale, heelScale);

            float meshScale = Mathf.Lerp(1.0f, 0.01f, t);
            
            meshParent.transform.localScale = new Vector3(meshScale, meshScale, meshScale);
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

