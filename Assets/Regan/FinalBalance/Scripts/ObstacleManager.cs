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
        }

        void Update()
        {
            foreach (Transform obstacle in _obstacles)
            {
                obstacle.position = new Vector3(obstacle.position.x, obstacle.position.y - Time.deltaTime * _obstacleSpeed, 10);
            }
        }
    }
}