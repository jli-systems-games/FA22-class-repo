using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Regan.Balance
{
    public class ObstacleManager : MonoBehaviour
    {
        [SerializeField]
        private float _obstacleSpeed;

        private List<Transform> _obstacles = new();

        private void Start()
        {
            FindObstacles();
        }

        private void FindObstacles()
        {
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Regan.balance.obstacle");
            foreach (GameObject obstacle in obstacles)
            {
                _obstacles.Add(obstacle.transform);
            }

            GameObject[] collectables = GameObject.FindGameObjectsWithTag("Regan.balance.collectable");
            foreach (GameObject collectable in collectables)
            {
                _obstacles.Add(collectable.transform);
            }

            GameObject[] finishLines = GameObject.FindGameObjectsWithTag("Regan.balance.finish");
            foreach (GameObject finish in finishLines)
            {
                _obstacles.Add(finish.transform);
            }
        }

        void Update()
        {
            foreach (Transform obstacle in _obstacles)
            {
                if (obstacle == null) continue;

                obstacle.position = new Vector3(obstacle.position.x, obstacle.position.y - Time.deltaTime * _obstacleSpeed, 10);
            }
        }
    }
}