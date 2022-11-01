using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace HectorRodriguez
{

    public class Timer2 : MonoBehaviour
    {
        public float timeRemaining = 10;
        public bool timerIsRunning = false;
        public TextMeshProUGUI timeText;

        private void Start()
        {
            // Starts the timer automatically
            timerIsRunning = true;

        }
            void Update()
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    DisplayTime(timeRemaining);
                }
                else
                {
                    Debug.Log("Time has run out!");
                    timeRemaining = 0;
                    SceneManager.LoadScene("EndGameBAL");
                }
            }
            void DisplayTime(float timeToDisplay)
            {
                timeToDisplay += 1;
                float minutes = Mathf.FloorToInt(timeToDisplay / 60);
                float seconds = Mathf.FloorToInt(timeToDisplay % 60);
                timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
        }
    }