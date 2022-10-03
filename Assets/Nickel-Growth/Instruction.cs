using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace nickelGrowth
{
    public class Instruction : MonoBehaviour
    {
        // Start is called before the first frame update

        public TMP_Text nameBox;
        public TMP_Text descriptionBox;
        public int propID;
        private string[] propName = {"Kindling", "Bard's flute", "Fairy's wings" };
        private string[] instructionList = { "Prolong the duration of your torch by 20s", "Increase lighting range for 10s", "Increase movement speed by 20s" };

        public GameObject textBackground;
        void Start()
        {
            nameBox.text = " ";
            descriptionBox.text = " ";
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(showDescription());
        }

        IEnumerator showDescription()
        {
            textBackground.SetActive(true);
            nameBox.text = propName[propID];
            descriptionBox.text = instructionList[propID];
            yield return new WaitForSeconds(4);
            nameBox.text = " ";
            descriptionBox.text = " ";
            textBackground.SetActive(false);
            this.enabled = false;
        }
    }
}

