using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerer : MonoBehaviour
{

    public AudioSource theMusic;

    public bool startPlaying;

    //·¢ÉäÆ÷
    public FirePoint theFPA;
    public FirePoint theFPS;
    public FirePoint theFPD;
    public FirePoint theFPJ;
    public FirePoint theFPK;
    public FirePoint theFPL;

    public static GameManagerer instance;

    public int hillScore;
    public int heavenScore;
    public int scorePerNote = 100;

    public GameObject hitted;
    public GameObject missed;

    public TextMeshProUGUI hellText;
    public TextMeshProUGUI heavenText;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
               


                startPlaying = true;
                theFPA.hasStarted = true;
                theFPS.hasStarted = true;
                theFPD.hasStarted = true;
                theFPJ.hasStarted = true;
                theFPK.hasStarted = true;
                theFPL.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        hillScore += scorePerNote;

        Instantiate(hitted, new Vector3(0, 0, 0), Quaternion.identity);

        hellText.text = "0" + hillScore;
    }

    public void NoteHit2()
    {
        Debug.Log("Hit On Time");

        heavenScore += scorePerNote;

        Instantiate(hitted, new Vector3(0, 0, 0), Quaternion.identity);

        heavenText.text = "0" + heavenScore;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");

       // Instantiate(missed, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void NoteMissed2()
    {
        Debug.Log("Missed");

        //Instantiate(missed, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
