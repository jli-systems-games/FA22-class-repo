using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace MarianaVampireSurvivors
{
    public class Timerend : MonoBehaviour
        

    {

        [SerializeField] private float timer = 60f;
        private TextMeshProUGUI timerSeconds;

        // Start is called before the first frame update
        void Start()
        {
            timerSeconds = GetComponent<TextMeshProUGUI>();
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;
            timerSeconds.text = timer.ToString("f2");
            if (timer <= 0)
            {
                SceneManager.LoadScene(2);

            }
        }
    }

}