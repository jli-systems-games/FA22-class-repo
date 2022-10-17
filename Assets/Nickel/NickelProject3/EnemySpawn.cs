using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

namespace nickelLifelike
{
    public class EnemySpawn : MonoBehaviour
    {
        public Transform[] ThisWaypoints;
        public GameObject enemyPrefab;
        public Transform spawnPoint;

        private float time=5;
        private float nextTimeFire;
        private float fireRate= 0.2f;

        public int spawnID;

        public TMP_Text TextBox;
        // Start is called before the first frame update
        void Start()
        {
            TextBox.text = " ";
        }

        // Update is called once per frame
        void Update()
        {
            time += Time.deltaTime;
            nextTimeFire = 1 / fireRate;
            if (time >= nextTimeFire)
            {
                
                GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                enemy.GetComponent<PathFollower>().waypoints = ThisWaypoints;
                time = 0;
                
            }
            if (spawnID == 2)
            {
                
                    StartCoroutine(Wave());
                
            }


        }

        IEnumerator Wave()
        {
            yield return new WaitForSeconds(20);
            fireRate = 0.6f;
            TextBox.text = "Wave Coming!";
            yield return new WaitForSeconds(7);
            fireRate = 0.2f;
            TextBox.text = " ";
        }

        
    }

}
