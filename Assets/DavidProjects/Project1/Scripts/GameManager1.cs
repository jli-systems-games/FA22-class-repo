using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class GameManager1 : MonoBehaviour
    {
        public ParticleSystem explosionEffect;
        public GameObject gameOverUI;

        private void Start()
        {
            NewGame();
        }

        private void Update()
        {

        }

        public void NewGame()
        {
            Monster[] asteroids = FindObjectsOfType<Monster>();

            for (int i = 0; i < asteroids.Length; i++)
            {
                Destroy(asteroids[i].gameObject);
            }

            gameOverUI.SetActive(false);
        }


        public void MonsterDestroyed(Monster monster)
        {
            explosionEffect.transform.position = monster.transform.position;
            explosionEffect.Play();

        }


        public void GameOver()
        {
            gameOverUI.SetActive(true);
        }


    }
}