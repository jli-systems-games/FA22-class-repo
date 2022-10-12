using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class EnemySpawn : MonoBehaviour
    {
        public Transform[] ThisWaypoints;
        public GameObject enemyPrefab;
        public Transform spawnPoint;

        private float time=5;
        private float nextTimeFire;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            time += Time.deltaTime;
            nextTimeFire = 1 / 0.5f;
            if (time >= nextTimeFire)
            {
                GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                enemy.GetComponent<PathFollower>().waypoints = ThisWaypoints;
                time = 0;
            }
        }

        IEnumerator EnemyAppear()
        {
            yield return new WaitForSeconds(3);
            GameObject enemy=Instantiate(enemyPrefab,spawnPoint.position, Quaternion.identity);
            enemy.GetComponent<PathFollower>().waypoints = ThisWaypoints;
        }
    }

}
