using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    

public class SFXControl : MonoBehaviour
{
    public Animator[] sfx;


    public void Animate()
    {
        sfx[0].SetTrigger("Attack");
      sfx[1].SetTrigger("Attack"); 
        
    }

}
}
