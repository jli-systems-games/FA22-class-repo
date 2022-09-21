using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace NickelArcade
{
    public class PrintScore : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject printPlayer1Score;
        public GameObject printPlayer2Score;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            printPlayer1Score.GetComponent<TMP_Text>().text = "Pink-" + TerritoryChangeColor.player1Score.ToString();
            printPlayer2Score.GetComponent<TMP_Text>().text = "Blue-" + TerritoryChangeColor.player2Score.ToString();
        }
    }
}
