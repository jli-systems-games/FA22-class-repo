using System.Collections;
using UnityEngine;

namespace samantha_zak.Lifelike_2.Scripts
{


    public class LightCollider : MonoBehaviour
    {

        public GameObject objectToSpawn;

        public GameObject spawnToObject;

        //public GameObject lightObject;


        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("collectibleSam"))
            {
                StartCoroutine(ShowAndHide(objectToSpawn, 3.0f)); // 3 seconds

                IEnumerator ShowAndHide(GameObject go, float delay)
                {
                    go.SetActive(true);
                    yield return new WaitForSeconds(delay);
                    go.SetActive(false);
                }
            }
            /* if (other.gameObject.CompareTag("collectibleSam"))
             {
                 Instantiate(objectToSpawn, spawnToObject.transform);
             }
         }*/
           /* void Update()
            {
                Instantiate(objectToSpawn, spawnToObject.transform);

            }
           */
        }
    }
}