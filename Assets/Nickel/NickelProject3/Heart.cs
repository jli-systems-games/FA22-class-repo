using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class Heart : MonoBehaviour
    {
        public GameObject gameOverScene;
        private int maxEnemy = 0;
        private float timeLeft = 120;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            //Debug.Log(maxEnemy);
            if (maxEnemy < 5 && timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else if (maxEnemy > 5 && timeLeft > 0)
            {
                Debug.Log("Game Over");
                gameOverScene.SetActive(true);
            }
            else if (timeLeft < 0)
            {
                Debug.Log("You win!");
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            maxEnemy++;
            Destroy(collision.gameObject);
        }
    }

}
