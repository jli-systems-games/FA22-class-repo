using UnityEngine;
using System.Collections;

namespace Mariana
{

    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject EnemyPrefab;

        [SerializeField]
        private float enemyInterval = 3f;

        private void Start()
        {
            StartCoroutine(spawnEnemy(enemyInterval, EnemyPrefab));
        }
        private IEnumerator spawnEnemy(float interval, GameObject enemy)
       {
           yield return new WaitForSeconds(interval);
           GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
            StartCoroutine(spawnEnemy(interval, enemy));

       }

    }

}
