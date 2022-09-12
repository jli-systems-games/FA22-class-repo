using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = GameManager.instance.score.ToString();
    }
}
