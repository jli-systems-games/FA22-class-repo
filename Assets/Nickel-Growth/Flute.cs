using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{
    public class Flute : MonoBehaviour
    {
        public Light torchLight;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            torchLight.range = 45;
            StartCoroutine(TorchWider());
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<CapsuleCollider>().enabled = false;
            StartCoroutine(propRefresh());
        }

        IEnumerator TorchWider()
        {
            yield return new WaitForSeconds(10);
            torchLight.range = 20;
        }

        IEnumerator propRefresh()
        {
            yield return new WaitForSeconds(30);
            this.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<CapsuleCollider>().enabled = true;
        }
    }

}

