using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class trashspawner : MonoBehaviour
    {

        public GameObject trashPrefab;
        public Transform[] spawnPoints;


        public float minDelay = .1f;
        public float maxDelay = 1f;



        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnTrash());
        }


        IEnumerator SpawnTrash()
        {
            while (true)
            {


                float delay = Random.Range(minDelay, maxDelay);
                yield return new WaitForSeconds(3f);

                int spawnIndex = Random.Range(0, spawnPoints.Length);
                Transform spawnPoint = spawnPoints[spawnIndex];





                GameObject spawnedTrash = Instantiate(trashPrefab, spawnPoint.position, spawnPoint.rotation);
                Destroy(spawnedTrash, 10f);


            }
        }


    }
}
