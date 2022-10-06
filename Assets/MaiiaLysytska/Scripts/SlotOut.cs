using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotOut : MonoBehaviour
{

    public bool unicorn1;
    public bool unicorn2;
    public bool unicornChild;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unicorn1 == true && unicorn2 == true && unicornChild == false)
        {
            Debug.Log("aa");
        }
    }



}
