using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour

   
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public float beatTempo;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);

                GameManagerer.instance.NoteHit();
            }
        }

        transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManagerer.instance.NoteMissed();
        }
    }

}
