using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Aisha
{
    public class ScoreScript : MonoBehaviour
    {
        Score score;
        public TMP_Text pointsText;

        public void SetUp (int score)
        {
            gameObject.SetActive(true);
            // Score.score = score.ToString() + " POINTS";
        }
        // Score score;
        // [SerializeField] GameObject ScoreNumber;
        // public static float scoreFinal;
        // public Text Feedback;
        // public TextMeshProUGUI WinScore;

        // // Start is called before the first frame update
        // void Start()
        // {

        // }

        // // Update is called once per frame
        // void Update()
        // {
        //     GameObject.Find("Score").GetComponent<Score>().score = scoreFinal;
        //     WinScore.text = "Score: " + scoreFinal;
        // }
    }
}