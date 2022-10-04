using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{
    public class SpeedUpBall : MonoBehaviour
    {
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
            StartCoroutine(speedUp());
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<SphereCollider>().enabled = false;
            StartCoroutine(propRefresh());
        }

        IEnumerator speedUp()
        {

            TheFirstPerson.FPSController.moveSpeed += 2;
            yield return new WaitForSeconds(10);
            TheFirstPerson.FPSController.moveSpeed -= 2;
        }

        IEnumerator propRefresh()
        {
            yield return new WaitForSeconds(30);
            this.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<SphereCollider>().enabled = true;
        }
    }
}


