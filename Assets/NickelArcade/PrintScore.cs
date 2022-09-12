using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject printPlayer1Score;
    public GameObject printPlayer2Score;
    void Start()
    {
        printPlayer1Score.GetComponent<TextMeshPro>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
        printPlayer1Score.GetComponent<TMP_Text>().text = "Red--" +TerritoryChangeColor.player1Score.ToString(); 
        printPlayer2Score.GetComponent<TMP_Text>().text = "Blue--" +TerritoryChangeColor.player2Score.ToString();
    }
}
