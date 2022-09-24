using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Regan
{
    public class ArcadeManager : MonoBehaviour
    {
        public static ArcadeManager instance;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
            }

        }

        public delegate void NextRoundDelegate();
        public static event NextRoundDelegate OnNextRound;


        public Transform worldTranform;
        [SerializeField]
        private GameObject playerPrefab;
        [SerializeField]
        private float respawnCooldown = 2;
        [SerializeField]
        private float restartCooldown = 2;

        public Vector2 worldBounds;

        public GameObject[] astroidTypes;
        [HideInInspector]
        public int currentAstroidAmount = 0;
        [HideInInspector]
        public SpaceShipController player;
        [HideInInspector]
        public int score = 0;
        [HideInInspector]
        public int highScore = 0;
        [HideInInspector]
        public int lives = 3;
        [HideInInspector]
        public bool gameover = false;

        private void Start()
        {
            highScore = PlayerPrefs.GetInt("highScore");
            respawnPlayer();

        }

        private void Update()
        {
            highScore = Mathf.Max(highScore, score);

            if (currentAstroidAmount > 0) { return; }
            NextRound();
        }

        private void NextRound()
        {
            OnNextRound?.Invoke();
        }

        public void AddScore()
        {
            score++;
        }

        public void PlayerDestroyed()
        {
            player = null;
            lives--;

            if (lives == 0)
            {
                gameover = true;
                PlayerPrefs.SetInt("highScore", highScore);
                StartCoroutine(RestartCooldown());
                return;
            }

            StartCoroutine(RespawnCooldown());
        }

        private IEnumerator RespawnCooldown()
        {
            float time = respawnCooldown;

            while (time > 0)
            {
                time -= Time.deltaTime;
                yield return null;
            }

            respawnPlayer();
        }

        private void respawnPlayer()
        {
            GameObject playerObject = Instantiate(playerPrefab, worldTranform);

            player = playerObject.GetComponent<SpaceShipController>();

        }

        private IEnumerator RestartCooldown()
        {
            float time = restartCooldown;

            while (time > 0)
            {
                time -= Time.deltaTime;
                yield return null;
            }

            SceneManager.LoadScene("FullGameScene");
        }
    }

}
