using TMPro;
using UnityEngine;

namespace AishaBikebayeva.Arcade_Game.Scripts
{
    public class ScoreScript : MonoBehaviour
    {
        // Score score;
        // public TMP_Text pointsText;

        // public void SetUp (int score)
        // {
        //     gameObject.SetActive(true);
        //     // Score.score = score.ToString() + " POINTS";
        // }
        // Score score;
        // [SerializeField] GameObject ScoreNumber;
        public static float scoreFinal;
        public TextMeshProUGUI WinScore;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // GameObject.Find("Score").GetComponent<Score>().score = scoreFinal;
            scoreFinal = Score.score;
            WinScore.text = "Score: " + scoreFinal;
        }
    }
}