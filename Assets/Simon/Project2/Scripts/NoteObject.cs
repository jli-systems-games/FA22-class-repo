using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon.Project2.Scripts 
{
        
    public class NoteObject : MonoBehaviour
    {

        public bool canBePressed;

        public KeyCode keyToPress;

        public GameObject hitEffect, goodEffect, perfectEffect, missEffect;

        void Start()
        {
            
        }

        void Update()
        {
            if (Input.GetKeyDown(keyToPress))
            {
                if (canBePressed)
                {
                    gameObject.SetActive(false);

                    if (Mathf.Abs(transform.position.y) > 0.25)
                    {
                        Debug.Log("Hit");
                        GameManager.instance.NormalHit();
                        Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
                    } else if (Mathf.Abs(transform.position.y) > 0.075f)
                    {
                        Debug.Log("Good");
                        GameManager.instance.GoodHit();
                        Instantiate(goodEffect, transform.position, hitEffect.transform.rotation);

                    }
                    else
                    {
                        Debug.Log("Perfect");
                        GameManager.instance.PerfectHit();
                        Instantiate(perfectEffect, transform.position, hitEffect.transform.rotation);

                    }
                    
                    //GameManager.instance.NoteHit();
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Activator")
            {
                canBePressed = true;
            }
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.tag == "Activator" && gameObject.activeSelf)
            {
                canBePressed = false;
                
                GameManager.instance.NoteMissed();
                Instantiate(missEffect, transform.position, hitEffect.transform.rotation);

            }
        }
    }
    
}

