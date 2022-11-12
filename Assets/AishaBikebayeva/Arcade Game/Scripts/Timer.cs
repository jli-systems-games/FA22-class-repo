using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AishaBikebayeva.Arcade_Game.Scripts
{
    public class Timer : MonoBehaviour
    {
        public TMP_Text textdisplay;
        public Image bardisplay;

        public float timerDuration = 100;
        float timer = 0f;
        // Start is called before the first frame update
        void Start()
        {
            timer = timerDuration;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;
            textdisplay.text = "Time left: " + timer.ToString("0") + " secs";
            bardisplay.fillAmount = timer / timerDuration;

            if (timer < 0)
            {
                timer = timerDuration;
                Debug.Log("Time has ended!");
                SceneManager.LoadScene("Win");
            }

        }
    }
}