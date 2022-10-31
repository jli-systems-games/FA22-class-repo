using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
public class ParticleWater : MonoBehaviour
{

   private void OnCollisionEnter2D(Collision2D collision)
   {
        GetComponent<ParticleSystem>().Play();
        Debug.Log("hit");
       // GetComponent<SpriteRenderer>().enabled = false;
    
   }
    
   
    
}
}