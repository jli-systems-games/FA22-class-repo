using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class GameManager1 : MonoBehaviour
    {



        private void Start()
        {
            NewGame();
        }

        private void Update()
        {

        }

        public void NewGame()
        {
            Monster[] monsters = FindObjectsOfType<Monster>();

            for (int i = 0; i <= monsters.Length; i++)
            {
                Destroy(monsters[i].gameObject);
            }

        }
    }
}