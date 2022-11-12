using System.Collections;
using UnityEngine;

namespace Nickel.NickelBalanace.script
{
    public class Collect : MonoBehaviour
    {
        public int cd=6;
        public GameObject prefab;
        public Transform hand;

        public GameObject[] keyInstructions;

        public GameObject process;


        private bool canCollect=false;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (canCollect && Input.GetKeyDown("q"))
            {
                process.SetActive(true);
                startProcessing();
            }
        }

        private void startProcessing()
        {

            process.GetComponent<Animator>().Play("processing",0,0.0f);
            StartCoroutine(processing(cd));
        }

        IEnumerator processing(int cd)
        {
            yield return new WaitForSeconds(cd);
            Instantiate(prefab, hand.position, Quaternion.identity);
        }

        private void OnTriggerEnter(Collider other)
        {
            canCollect = true;
            for(int i = 0; i < keyInstructions.Length; i++)
            {
                keyInstructions[i].SetActive(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            canCollect = false;
            for (int i = 0; i < keyInstructions.Length; i++)
            {
                keyInstructions[i].SetActive(false);
            }
        }

        
    }

}
