using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aisha
{
    public class StonesSpawn: MonoBehaviour
    {
        public GameObject Prefab;
        public float timeBetweenSpawns; //interval of time to wait between spawn in seconds

        public float ySpawnPosMin; //up most spawn point
        public float ySpawnPosMax; //down most spawn point
        public float xSpawnPos; //width of spawn
        public float spawnInterval = 3;
        public float currentSpawnTime = 0;
        public float bigCountdown = 30; 
        public float currentBigTime = 0;


        //private variables can't be accessed by other scripts
        private float timeUntilSpawn;

        public void Start()
        {
            timeUntilSpawn = 1;
        }

        public void Update()
        {
            //Time.deltaTime is how much time has occured since the last update. 
            //If we decrease the timer by Time.deltaTime every time Update() runs, the timer will decrease by 1.0 every second.
            timeUntilSpawn -= Time.deltaTime;
            //Once timeUntilSpawn is less than 0, we spawn a new hat
            if (timeUntilSpawn <= 0)
            {
                Spawn();
                //then we reset timeUntilSpawn to the timeBetweenSpawns & start all over again
                timeUntilSpawn = timeBetweenSpawns;
            }
            currentSpawnTime += Time.deltaTime;
            currentBigTime += Time.deltaTime;
        
            if(currentSpawnTime >= spawnInterval){
                Spawn();
                currentSpawnTime = 0;
            }
        
            if(currentBigTime >= bigCountdown){
                spawnInterval -= .1f;
                currentBigTime = 0;
            }
        }

        private void Spawn()
        {
            //Generate a new spawn position. 
            //For the first value of this Vector3 (x) we use Random.Range to get a position between our min & max X values
            //The second (y) is just the height we spawn at
            //The third (z) is the depth, which is set to 0 as we're in 2D
            Vector3 newPos = new Vector3(xSpawnPos, Random.Range(ySpawnPosMin, ySpawnPosMax), 0);
            //Instantiate creates a new object from a prefab. It needs the prefab, the position, and the rotation as arguements
            //newPos is the position we made, Quaternion.identity just means that we're not rotating the sprite
            Instantiate(Prefab, newPos, Quaternion.identity);
        }



    }
}