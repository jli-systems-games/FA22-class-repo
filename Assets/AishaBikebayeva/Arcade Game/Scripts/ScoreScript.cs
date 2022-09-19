using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Aisha
{
    
    public class ScoreScript : MonoBehaviour
    {
        public static float scoreNum;
        public Text Feedback;
        public TextMeshProUGUI WinScore;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // scoreNum = Score.scoreText;

            WinScore.text = "Final Score: " + scoreNum;
        }
    }

}