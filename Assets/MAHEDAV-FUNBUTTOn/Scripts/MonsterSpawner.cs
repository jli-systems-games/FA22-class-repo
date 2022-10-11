using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{

    public class MonsterSpawner : MonoBehaviour
    {
        public Monster monsterPrefab;
        public float spawnDistance = 12f;
        public float spawnRate = 1f;
        public int amountPerSpawn = 1;
        [Range(0f, 45f)] public float trajectoryVariance = 15f;

        private void Start()
        {
            InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
        }

        public void Spawn()
        {
            for (int i = 0; i < amountPerSpawn; i++)
            {
                Vector2 spawnDirection = Random.insideUnitCircle.normalized;
                Vector3 spawnPoint = spawnDirection * spawnDistance;

                spawnPoint += transform.position;

                float variance = Random.Range(-trajectoryVariance, trajectoryVariance);
                Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

                Monster monster = Instantiate(monsterPrefab, spawnPoint, rotation);


                Vector2 trajectory = rotation * -spawnDirection;
                monster.SetTrajectory(trajectory);
            }
        }
    }
}