using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerer : MonoBehaviour
{

    public AudioSource theMusic;

    public bool startPlaying;

    public FirePoint theFPA;
    public FirePoint theFPS;
    public FirePoint theFPD;
    public FirePoint theFPJ;
    public FirePoint theFPK;
    public FirePoint theFPL;

    public static GameManagerer instance;


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

    }

    public void NoteMissed()
    {
        Debug.Log("Missed");

    }
}
