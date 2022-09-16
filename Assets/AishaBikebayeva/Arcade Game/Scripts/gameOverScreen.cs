using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Aisha
{
    public class GameOverScreen : MonoBehaviour
    {
        public Text pointsText;

        public void SetUp (int score)
        {
            gameObject.SetActive(true);
            pointsText.text = score.ToString() + " POINTS";
        }

        public void Exit()
        {
            SceneManager.LoadScene("GameOver");
        }
    }  
}