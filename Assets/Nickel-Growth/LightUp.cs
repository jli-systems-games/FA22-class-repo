using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace nickelGrowth
{
    public class LightUp : MonoBehaviour
    {
        // Start is called before the first frame update
        public Light frame;
        public int lightHouseOrderID;
        public static int finishedLH = 0;
        public static int currentTemple=0;
        public GameObject lightBall;
        public GameObject lightColumn;

        public GameObject distDetect;

        public GameObject textBox;

        public AudioSource soundEffect;
        private string[] lightHouseAnnounce= {" ","Eye","Leg","Body" };
        void Start()
        {
            textBox.GetComponent<TMP_Text>().text = " ";
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            finishedLH++;
            frame.enabled = true;
            this.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(ShowLightHouseText());
            currentTemple = lightHouseOrderID;
            distDetect.SetActive(true);
            soundEffect.Play();
            
        }

        IEnumerator ShowLightHouseText()
        {
            if (finishedLH < 4)
            {
                yield return new WaitForSeconds(1);

                textBox.GetComponent<TMP_Text>().text = "To bring the light back to the world, offer your "
                                                         + lightHouseAnnounce[finishedLH] + " to the God of Light.";
                yield return new WaitForSeconds(5);
                textBox.GetComponent<TMP_Text>().text = " ";
                yield return new WaitForSeconds(1);
                textBox.GetComponent<TMP_Text>().text = "May the God of Light bless you";
                yield return new WaitForSeconds(3);
                textBox.GetComponent<TMP_Text>().text = " ";

                yield return new WaitForSeconds(1);
                lightBall.SetActive(true);
            }else if (finishedLH == 4)
            {
                yield return new WaitForSeconds(1);
                textBox.GetComponent<TMP_Text>().text = "All lighthouses have been lit. Please release our power at the altar.";
                yield return new WaitForSeconds(5);
                textBox.GetComponent<TMP_Text>().text = " ";
                lightBall.SetActive(true);
                lightColumn.SetActive(true);
            }
            


        }
    }

}
