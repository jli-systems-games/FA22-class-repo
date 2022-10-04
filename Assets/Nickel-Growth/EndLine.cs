using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace nickelGrowth
{
    public class EndLine : MonoBehaviour
    {
        // Start is called before the first frame update
        public TMP_Text instruction;
        public GameObject currentCamera;
        public GameObject currentLight;
        public GameObject newCamera;
        public GameObject newLightAnim;

        public AudioSource bgm;

        public GameObject UIs;
        
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (LightUp.finishedLH < 4)
            {
                StartCoroutine(instruct1());
            }
            else if (LightUp.finishedLH == 4)
            {


                bgm.Play();
                Torch.torchTime = 999999;
                StartCoroutine(instruct2());
                StartCoroutine(endAnim());
                this.GetComponent<BoxCollider>().enabled = false;
                
            }
        }


        IEnumerator endAnim()
        {
            yield return new WaitForSeconds(12);
            currentCamera.SetActive(false);
            newCamera.SetActive(true);
            newLightAnim.SetActive(true);
            UIs.SetActive(false);


        }

        IEnumerator instruct1()
        {
            instruction.text = "Come back when all the temples are lit";
            yield return new WaitForSeconds(3);
            instruction.text = " ";

        }
        IEnumerator instruct2()
        {
            instruction.text = "Go up, this is the end of your journey.";
            yield return new WaitForSeconds(3);
            instruction.text = " ";

        }
    }

}
