using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Animator anim;
    bool EffectAnim = false;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

 void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Ground"))
        {
            EffectAnim = true;
            anim.Play("rotatingside", -1, 0f);
        }
    }
}
