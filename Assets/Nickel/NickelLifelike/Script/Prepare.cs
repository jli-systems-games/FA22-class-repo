using System.Collections;
using TMPro;
using UnityEngine;

namespace Nickel.NickelLifelike.Script
{
    public class Prepare : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject[] setUps;
        public TMP_Text prepareBox;
        void Start()
        {
            prepareBox.text = " ";
            StartCoroutine(StartGame());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator StartGame()
        {
            yield return new WaitForSeconds(1);
            prepareBox.text = "Set Up your defenders";
            yield return new WaitForSeconds(15);

            for (int i = 0; i < setUps.Length; i++)
            {
                setUps[i].SetActive(true);
            }
            prepareBox.text = "Enemy Coming!";

            yield return new WaitForSeconds(3);
            prepareBox.text = " ";


        }
    }

}
