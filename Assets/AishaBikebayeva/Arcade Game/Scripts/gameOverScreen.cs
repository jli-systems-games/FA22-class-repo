using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AishaBikebayeva.Arcade_Game.Scripts
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