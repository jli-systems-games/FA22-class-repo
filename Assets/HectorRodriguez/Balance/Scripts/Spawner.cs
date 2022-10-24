using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class Spawner : MonoBehaviour
    {
        public GameObject spawnObject;
        public Vector3 spawnPoint;
        public int maxX = 10;
        public int timeTilNextSpawn = 5;
        int x = 0;
        float timer = 0;

        void Start()
        {
            timer = 0;
            spawnPoint.x = x;
        }

        private void Update()
        {
            timer += Time.deltaTime;
            Spawn();
        }

        void Spawn()
        {
            if (timer >= timeTilNextSpawn)
            {
                x = Random.Range(0, maxX);
                spawnPoint.x = x;
                Instantiate(spawnObject, spawnPoint, Quaternion.identity);
                timer = 0;
            }
        }
    }
}