using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Bananagodzilla
{
    

public class BeetleLoose : MonoBehaviour
{
    public GameObject Lost;
    public GameObject leaf;
    public TMP_Text timerr;
    public GameObject timer;


    public float targetTime = 5f;

    public bool Dropped = false;
    // Start is called before the first frame update
    void Start()
    {
        timerr = timer.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Dropped == true)
        {
            
            targetTime -= Time.deltaTime;
            timerr.SetText( MathF.Round(targetTime, 2, MidpointRounding.AwayFromZero).ToString() + "s");
            
    Debug.Log(targetTime);
        }

        if (Dropped == false)
        {
            targetTime = 5f;
        }

        if (targetTime <= 0)
        {
            Lose();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("bullet")){
            timer.SetActive(true);
        Dropped = true;
        Debug.Log("Dropped");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("bullet"))
        {
            timer.SetActive(false);
            Dropped = false;
            Debug.Log("PickedUp");
        }
    }

    void Lose()
    {
        Debug.Log("Lost");
    }
}
}