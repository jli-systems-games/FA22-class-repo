using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TerritoryChangeColor.player1Score = 0;
        TerritoryChangeColor.player2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
