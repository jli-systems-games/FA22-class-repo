using TMPro;
using UnityEngine;

namespace AishaBikebayeva.AishaLifelike.Scripts{
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
            endscore = LifeScore.score;

            scoreText.text = "Final Score: " + LifeScore.score;
        }
    }
}