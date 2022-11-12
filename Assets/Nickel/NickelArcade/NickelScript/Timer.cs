using TMPro;
using UnityEngine;

namespace Nickel.NickelArcade.NickelScript
{
    public class Timer : MonoBehaviour
    {
        // Start is called before the first frame update
        public float TimeLeft;
        public bool TimerOn = false;

        public TMP_Text timeText;
        void Start()
        {
            TimerOn = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (TimerOn)
            {
                if (TimeLeft > 0)
                {
                    TimeLeft -= Time.deltaTime;
                    updateTimer(TimeLeft);
                }
                else
                {
                    Debug.Log("time is up");
                    TimeLeft = 0;
                    TimerOn = false;
                }
            }
        }

        void updateTimer(float currentTime)
        {
            currentTime += 1;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}


