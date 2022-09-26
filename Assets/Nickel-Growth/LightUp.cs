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

        public GameObject textBox;
        public string[] lightHouseAnnounce;
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
            
        }

        IEnumerator ShowLightHouseText()
        {
            yield return new WaitForSeconds(1);
            for(int i = 0; i < lightHouseAnnounce.Length; i++)
            {
                textBox.GetComponent<TMP_Text>().text = lightHouseAnnounce[i];
                yield return new WaitForSeconds(3);
                textBox.GetComponent<TMP_Text>().text = " ";
                yield return new WaitForSeconds(1);
            }
            
        }
    }

}
