using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Regan {

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro scoreText;
    [SerializeField]
    private TextMeshPro livesText;
    [SerializeField]
    private TextMeshPro highScoreText;
    [SerializeField]
    private TextMeshPro gameOverText;

    [SerializeField]
    private float blinkPeriod = 1;
    private float blinkTimeLeft = 1;

    private void Update()
    {
        UpdateScore();
        UpdateLives();
        UpdateGameOver();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        highScoreText.text = GameManager.instance.highScore.ToString();
    }

    private void UpdateScore()
    {
        scoreText.text = GameManager.instance.score.ToString();
    }

    private void UpdateLives()
    {
        string livesString = "";
        for (int i = 0; i < GameManager.instance.lives; i++)
        {
            livesString += 'X';
        }
        livesText.text = livesString;
    }

    private void UpdateGameOver()
    {
        if (blinkTimeLeft <= 0)
        {
            blinkTimeLeft = blinkPeriod;

            gameOverText.enabled = !gameOverText.enabled && GameManager.instance.gameover;
        }
        blinkTimeLeft -= Time.deltaTime;
    }
    
}
}
