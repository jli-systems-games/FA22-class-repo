using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Bananagodzilla
{
    

public class BeetleLoose : MonoBehaviour
{
    public GameObject[] deadGrass;
    public MaiMove[] beetles;
    public GameObject Lost;
    //public GameObject leaf;
    public TMP_Text timerr;
    public GameObject timer;
    public bool canFall = true;

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

        if (canFall == true)
        {
            
            if (Dropped == true)
            { 

                targetTime -= Time.deltaTime;
                timerr.SetText(MathF.Round(targetTime, 2, MidpointRounding.AwayFromZero).ToString() + "s");

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

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("bullet")){
            timer.SetActive(true);
        Dropped = true;
       
        }
    }

    
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("bullet"))
        {
            timer.SetActive(true);
       
          
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("bullet"))
        {
            timer.SetActive(false);
            Dropped = false;
           
        }
    }

    void Lose()
    {
        for (int i = 0; i < deadGrass.Length; i++)
        {
            deadGrass[i].SetActive(false);
        }
       Lost.SetActive(true);
       for (int i = 0; i < beetles.Length; i++)
       {
           beetles[i].IfMoves();
       }
       
    }
}
}