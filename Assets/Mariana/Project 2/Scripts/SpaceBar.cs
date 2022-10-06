using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana

{
    public class SpaceBar : MonoBehaviour
    {
        Animator myAnimator;
        public AudioSource Eat;

        // Start is called before the first frame update
        void Start()
        {
            myAnimator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myAnimator.SetTrigger("space");
                Eat.Play();
            }


        }
    }
}
