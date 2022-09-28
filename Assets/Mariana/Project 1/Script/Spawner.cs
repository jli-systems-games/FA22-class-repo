using UnityEngine;
using System.Collections;

namespace Mariana
{

    public class Spawner : MonoBehaviour
    {
        public EnemyData enemyDataLoad;
        int enemyLimit=100;

        [SerializeField]
        private GameObject EnemyPrefabPurple;

        [SerializeField]
        private GameObject EnemyPrefabRed;

        [SerializeField]
        private float enemyInterval = 3f;

        int difficulty = 0;

        private void Start()
        {
            StartCoroutine(spawnEnemy(enemyInterval, EnemyPrefabPurple));
        }
        private IEnumerator spawnEnemy(float interval, GameObject enemy)
       {
           yield return new WaitForSeconds(interval);
           GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
            StartCoroutine(spawnEnemy(interval, enemy));
           // newEnemy.GetComponent <Enemy> ().data = enemyDataLoad;
           if(difficulty > 10)
            {
               Instantiate(EnemyPrefabRed, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
               
            }

            difficulty++; 

       }

    }

}
