using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour
{
    public GameObject PlasticPrefab;
    float randX;
    float randY;
    public Vector2 randomSpawnPosition;
    public float spawnRate = 2.0f;
    float nextSpawn = 0.0f;



    void Update()
    {

        if (Time.time > nextSpawn)
        {

            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(1f, 18f);
            randY = Random.Range(2f, 10f);
            randomSpawnPosition = new Vector2(randX, randY);
            Instantiate(PlasticPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}