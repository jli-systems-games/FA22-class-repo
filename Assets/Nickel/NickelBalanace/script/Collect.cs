using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelBalance
{
    public class Collect : MonoBehaviour
    {
        public int cd=3;
        public GameObject prefab;
        public Transform hand;

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
                startProcessing();
            }
        }

        private void startProcessing()
        {
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
        }

        private void OnTriggerExit(Collider other)
        {
            canCollect = false;
        }

        
    }

}
