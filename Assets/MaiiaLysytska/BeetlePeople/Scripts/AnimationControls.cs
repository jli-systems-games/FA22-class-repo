using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{

public class AnimationControls : MonoBehaviour
{
    public Animator anim;
   
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y > 1 || rb.velocity.y < -1 || rb.velocity.x < -1 || rb.velocity.x > 1)
        {
            anim.SetBool("IsWalking", true);
           
        }
        else{ anim.SetBool("IsWalking", false);}

        if (rb.velocity.x < -1)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(-1, 1, 0);
        }
        
        if (rb.velocity.x > 1)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(1, 1, 0);
        }

        
        
    }

    public void WinState()
    {
        anim.SetTrigger("Won");
    }
}
    
}
