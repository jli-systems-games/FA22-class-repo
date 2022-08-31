using System.Collections;
using System.Collections.Generic;
using MunroHoberman;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private float gameTime = 0;
    [SerializeField]private float surviveTime=60f;

    private string winScene="WerewolfReviversWin";
    private string loseScene="WerewolfReviversLose";
    

    [SerializeField]private TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime >= surviveTime)
        {
            SceneManager.LoadScene(winScene);
        }
        // if (player is dead)
        // {
        //     SceneManager.LoadScene(loseScene);
        // }

        timerText.text = FormatTime(gameTime);
    }
    string FormatTime( float time )
    {
        int minutes = (int) time / 60 ;
        int seconds = (int) time - 60 * minutes;
        return string. Format("{0:00}:{1:00}", minutes, seconds  );
    }
}
