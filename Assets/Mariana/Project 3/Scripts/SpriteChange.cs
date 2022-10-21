using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
    public class SpriteChange : MonoBehaviour
    {
      private Animator myAnimator;
        private void Start()
        {
            myAnimator = GetComponent<Animator>();

        }

        private void Update()
        {
            
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("ouch");
            myAnimator.SetTrigger("HitTrigger") ;
        }
    }
}
