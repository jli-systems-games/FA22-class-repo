using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
public class ParticleWater : MonoBehaviour
{

    public AudioClip splash;

    void Start ()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = splash;
    }
   private void OnCollisionEnter2D(Collision2D collision)
   {
        GetComponent<AudioSource>().Play();
        GetComponent<ParticleSystem>().Play();
        Debug.Log("hit");
       // GetComponent<SpriteRenderer>().enabled = false;
    
   }
    
   
    
}
}