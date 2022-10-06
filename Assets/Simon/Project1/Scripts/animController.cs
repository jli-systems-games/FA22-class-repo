using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon {

public class animController : MonoBehaviour
{
    public Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.Play("Grab");

            
        }
    }
}


}
