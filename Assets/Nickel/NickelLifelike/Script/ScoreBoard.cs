using TMPro;
using UnityEngine;

namespace Nickel.NickelLifelike.Script
{
    public class ScoreBoard : MonoBehaviour
    {
        public TMP_Text scoreBox;
        private int score = 0;
        private float time = 0;
        public float scoreRate = 5;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            scoreBox.text = "Score:" + score;
            time += Time.deltaTime;
            if (time >= scoreRate)
            {
                score += 10;
                time = 0;
            }

        }
    }

}
