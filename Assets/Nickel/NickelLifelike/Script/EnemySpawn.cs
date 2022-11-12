using TMPro;
using UnityEngine;

namespace Nickel.NickelLifelike.Script
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
        private float waveTime=30;
        private float waveTimer=0;

        private float timerTemp = 0;

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
                
                //Debug.Log(waveTimer);
                waveTimer += Time.deltaTime;
                if (waveTimer >= waveTime)
                {
                    fireRate = 0.6f;
                    TextBox.text = "Wave Coming!";
                    
                    timerTemp += Time.deltaTime;
                    if (timerTemp >= 7)
                    {
                        waveTimer = 0;
                        timerTemp = 0;
                    }
                    Debug.Log(timerTemp);
                    
                }
                else if(waveTimer < waveTime)
                {
                    fireRate = 0.2f;
                    TextBox.text = " ";
                }
                    
                
            }


        }

        //IEnumerator Wave()
        //{
        //    yield return new WaitForSeconds(20);
        //    fireRate = 0.6f;
        //    TextBox.text = "Wave Coming!";
        //    yield return new WaitForSeconds(7);
        //    fireRate = 0.2f;
        //    TextBox.text = " ";
        //}

        
    }

}
