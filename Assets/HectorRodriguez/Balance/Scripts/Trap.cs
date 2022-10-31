using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class Trap : MonoBehaviour
    {

        // Start is called before the first frame update
        public Animator mAnimator;

        void Start()
        {
            mAnimator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {

                if (this.gameObject.CompareTag("Trap"))
                {
                    Debug.Log("PlayerTrigger");
                    mAnimator.SetTrigger("Rotate");
                }
                else if (this.gameObject.CompareTag("Trap"))
                {
                    mAnimator.SetTrigger("Rotate2");
                }
            }

        }
    }
}