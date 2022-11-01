using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace nickelBalance
{
    public class TemperatureDetect : MonoBehaviour
    {
        public int ID;
        
        public float StartTmp;

        
        private float CurrentTmp;

        public GameObject TmpBar;

        public GameObject fire;
        public Animator anim = null;

        private bool tmpDecrease=false;
        private bool tmpIncrease=false;

        public GameObject imageBox;


        // Start is called before the first frame update
        void Start()
        {
            
            
                TmpBar.transform.localScale = new Vector3(0.18f, StartTmp, 0f);
            

            CurrentTmp = StartTmp;
           
        }

        // Update is called once per frame
        void Update()
        {
            TmpBar.transform.localScale = new Vector3(0.18f, CurrentTmp, 0f);
        

            if (tmpDecrease)
            {
                CurrentTmp -= 0.42f/40f * Time.deltaTime;
            }
            if (tmpIncrease)
            {
                CurrentTmp += 0.45f / 40f * Time.deltaTime;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            imageBox.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (ID == 2)
            {
                if (other.CompareTag("Player"))
                {
                    anim.Play("openDoor", 0, 0.0f);
                    imageBox.SetActive(true);
                    

                }
                if (other.CompareTag("Ice"))
                {
                    Debug.Log("enter");
                    CurrentTmp = 0.45f;
                    
                    StartCoroutine(timer1());
                }
            }
            if (ID == 1)
            {
                if (other.CompareTag("Player"))
                {
                    imageBox.SetActive(true);
                    
                }
                if (other.CompareTag("Fuel"))
                {
                    fire.SetActive(true);
                    //Debug.Log("enter");
                    CurrentTmp = 0.45f;
                    
                    StartCoroutine(timer2());
                }
            }
            
            
        }



        IEnumerator timer1()
        {
            yield return new WaitForSeconds(10);
            tmpIncrease = true;
            yield return new WaitForSeconds(40);
            if (tmpDecrease)
            {
                tmpDecrease = false;
            }
            if (tmpIncrease)
            {
                tmpIncrease = false;
            }
            
        }

        IEnumerator timer2()
        {
            yield return new WaitForSeconds(10);
            tmpDecrease = true;
            yield return new WaitForSeconds(40);
            
            if (tmpDecrease)
            {
                tmpDecrease = false;
            }
            if (tmpIncrease)
            {
                tmpIncrease = false;
            }

        }

      


        }

}

