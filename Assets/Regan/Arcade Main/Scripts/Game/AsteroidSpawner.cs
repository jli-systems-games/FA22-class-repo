using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan
{
    public class AsteroidSpawner : MonoBehaviour
    {
        [SerializeField]
        int _spawnAmount = 3;

        Vector2 _worldBounds;

        private void OnEnable()
        {
            ArcadeManager.OnNextRound += NextRound;
        }

        private void OnDisable()
        {
            ArcadeManager.OnNextRound -= NextRound;
        }

        private void Start()
        {
            _worldBounds = ArcadeManager.instance.worldBounds;
        }

        private void NextRound()
        {
            CreateAsteroids();

        }

        private void CreateAsteroids()
        {
            GameObject[] asteroidPrefabs = ArcadeManager.instance.astroidTypes;
            for (int i = 0; i < _spawnAmount; i++)
            {
                int randomId = Random.Range(0, asteroidPrefabs.Length - 1);
                CreateAsteroid(asteroidPrefabs[randomId]);

            }
        }

        private void CreateAsteroid(GameObject prefab)
        {
            GameObject asteroid = Instantiate(prefab, ArcadeManager.instance.worldTranform);
            asteroid.transform.position = GetRandomPosOnBounds();
            asteroid.transform.localScale *= Mathf.Max(Random.value * 4, 2);
            asteroid.GetComponent<Asteroid>().astroidStage = 2;
            asteroid.GetComponent<Rigidbody>().velocity = new Vector2((Random.value - 0.5f) * 3, (Random.value - 0.5f) * 3);
        }

        private Vector2 GetRandomPosOnBounds()
        {
            int sideIndex = Random.Range(0, 4);
            Vector2 position = new Vector2(Random.value * _worldBounds.x, Random.value * _worldBounds.y);
            switch (sideIndex)
            {
                case 0:
                    position.y = _worldBounds.y;
                    break;
                case 1:
                    position.y = -_worldBounds.y;
                    break;
                case 2:
                    position.x = _worldBounds.x;
                    break;
                case 3:
                    position.x = -_worldBounds.x;
                    break;
            }

            return position;
        }
    }
}
