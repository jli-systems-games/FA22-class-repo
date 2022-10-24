using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    

public class BeetleLoose : MonoBehaviour
{

    public GameObject leaf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == leaf)
        {
            Lose();
        }
    }

    void Lose()
    {
        Debug.Log("Lost");
    }
}
}