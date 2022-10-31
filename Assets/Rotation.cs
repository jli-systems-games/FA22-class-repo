using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Animator anim;
    


    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame

 void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Test");
            anim.SetTrigger("Rotate");
        }
       else if(other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("Rotate2");
        }
   
    }
}
