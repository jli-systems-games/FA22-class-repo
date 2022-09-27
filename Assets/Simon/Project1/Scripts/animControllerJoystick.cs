using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon{

public class animControllerJoystick : MonoBehaviour
{

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            anim.Play("JoystickLeft");
        }
        if (Input.GetKeyUp("left"))
        {
            anim.Play("JoystickLeftReturn");
        }
        
        if (Input.GetKeyDown("right"))
        {
            anim.Play("JoystickRight");
        }
        if (Input.GetKeyUp("right"))
        {
            anim.Play("JoystickRightReturn");
        }
        
        if (Input.GetKeyDown("up"))
        {
            anim.Play("JoystickUp");
        }
        if (Input.GetKeyUp("up"))
        {
            anim.Play("JoystickUpReturn");
        }
        
        if (Input.GetKeyDown("down"))
        {
            anim.Play("JoystickDown");
        }
        if (Input.GetKeyUp("down"))
        {
            anim.Play("JoystickDownReturn");
        }
    }
}

}


