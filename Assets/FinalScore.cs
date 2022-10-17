using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace AishaLifelike{
    public class FinalScore : MonoBehaviour
    {
        public static float endscore;
        // public Text Feedback;
        public TextMeshProUGUI scoreText;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            endscore = AishaLifelike.LifeScore.score;

            scoreText.text = "Final Score: " + AishaLifelike.LifeScore.score;
        }
    }
}