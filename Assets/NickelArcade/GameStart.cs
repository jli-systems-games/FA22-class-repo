using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStart : MonoBehaviour
{
    public List<string> subtitles;
    public GameObject subtBox;
   


    public GameObject player1Controller;
    public GameObject player2Controller;
    public GameObject startTiming;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TMP_Text>().text = " ";
        StartCoroutine(LoadSubtitles());
        player1Controller.GetComponent<NickelArcade.Player>().enabled = false;
        player2Controller.GetComponent<NickelArcade.Player>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    IEnumerator LoadSubtitles()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < subtitles.Count; i++)
        {

            yield return new WaitForSeconds(1);
            subtBox.SetActive(true);
            this.GetComponent<TMP_Text>().text = subtitles[i];
            yield return new WaitForSeconds(1);
            this.GetComponent<TMP_Text>().text = " ";
            subtBox.SetActive(false);

        }
        player1Controller.GetComponent<NickelArcade.Player>().enabled = true;
        player2Controller.GetComponent<NickelArcade.Player>().enabled = true;
        startTiming.SetActive(true);

        yield return new WaitForSeconds(60);
        this.GetComponent<TMP_Text>().text = "Time's Up!";
        startTiming.SetActive(false);
        player1Controller.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        player2Controller.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

        yield return new WaitForSeconds(2);
        if (TerritoryChangeColor.player1Score > TerritoryChangeColor.player2Score)
        {
            this.GetComponent<TMP_Text>().text = "Player1 Wins!";
        }
        else if (TerritoryChangeColor.player1Score < TerritoryChangeColor.player2Score)
        {
            this.GetComponent<TMP_Text>().text = "Player2 Wins!";

        }
        else
        {
            this.GetComponent<TMP_Text>().text = "Draw!";
        }
        



    }

   

}

