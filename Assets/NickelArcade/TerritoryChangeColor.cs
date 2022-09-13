using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerritoryChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public static int player1Score=0;
    public static int player2Score=0 ;

    private bool occupied=false;

    private bool player1GetScore=false;
    private bool player2GetScore=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player1")&& !player1GetScore)
        {
            transform.GetComponent<SpriteRenderer>().color = Color.red;

            player1GetScore = true;
            player2GetScore = false;

            if (!occupied)
            {
                player1Score++;
                occupied = true;
            }
            else if(occupied)
            {
                player1Score++;
                player2Score--;
            }
            
            
 

        }
        else if (collision.gameObject.CompareTag("Player2") && !player2GetScore)
        {
            transform.GetComponent<SpriteRenderer>().color = Color.blue;

            player2GetScore = true;
            player1GetScore = false;

            if (!occupied)
            {
                player2Score++;
                occupied = true;
            }
            else if (occupied)
            {
                player2Score++;
                player1Score--;
            }
            

           

        }
        
    }

    

}
