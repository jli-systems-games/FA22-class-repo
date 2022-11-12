using TMPro;
using UnityEngine;

namespace Nickel.NickelLifelike.Script
{
    public class Heart : MonoBehaviour
    {
        public GameObject gameOverScene;
        public GameObject WinScene;
        public GameObject[] stop;
        private int maxEnemy = 0;
        private float timeLeft = 120;

        public TMP_Text HealthBox;

        private int health=5;
        // Start is called before the first frame update
        void Start()
        {
            HealthBox.text = " ";
        }

        // Update is called once per frame
        void Update()
        {
            HealthBox.text = ""+(health-maxEnemy);

            //Debug.Log(maxEnemy);
            if (maxEnemy < health && timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else if (maxEnemy >= health && timeLeft > 0)
            {
                //Debug.Log("Game Over");
                gameOverScene.SetActive(true);
                for(int i = 0; i < stop.Length; i++)
                {
                    stop[i].SetActive(false);
                }
            }
            else if (timeLeft < 0)
            {
                //Debug.Log("You win!");
                WinScene.SetActive(true);
                for (int i = 0; i < stop.Length; i++)
                {
                    stop[i].SetActive(false);
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            maxEnemy++;
            Destroy(collision.gameObject);
        }
    }

}
