using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStart : MonoBehaviour
{
    public List<string> subtitles;
    public GameObject subtBox;
    public float time;

    private float timer1=8;
    public GameObject player1Controller;
    public GameObject player2Controller;
    public GameObject startTiming;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TMP_Text>().text = " ";
        StartCoroutine(LoadSubtitles());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer1);
        if (timer1 > 0)
        {
            timer1 -= Time.deltaTime;
        }
        else if (timer1<=0)
        {
            player1Controller.GetComponent<Player>().enabled = true;
            player2Controller.GetComponent<CharacterController>().enabled = true;
            startTiming.SetActive(true);
        }


    }

    IEnumerator LoadSubtitles()
    {
        yield return new WaitForSeconds(time);
        for (int i = 0; i < subtitles.Count; i++)
        {

            yield return new WaitForSeconds(1);
            subtBox.SetActive(true);
            this.GetComponent<TMP_Text>().text = subtitles[i];
            yield return new WaitForSeconds(1);
            this.GetComponent<TMP_Text>().text = " ";
            subtBox.SetActive(false);

        }


    }

   

}

