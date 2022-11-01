using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerer : MonoBehaviour
{

    public AudioSource theMusic;

    public bool startPlaying;

    public NoteHolder theNH;

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
                theNH.hasStarted = true;

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
