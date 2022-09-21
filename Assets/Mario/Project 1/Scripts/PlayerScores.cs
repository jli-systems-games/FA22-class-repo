using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MarioArcadeSoccer
{

    public class PlayerScores : MonoBehaviour
    {
        public int score;
        public TextMeshProUGUI scoreUI;

        // Update is called once per frame
        void Update()
        {
            scoreUI.text = score.ToString();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                score++;

            }
        }
    }
}