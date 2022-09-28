using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MaxArcade
{

    public class GameManager : MonoBehaviour
    {

        #region variables

        public enum GameState
        {
            Prepare,
            Playing,
            GameOver
        }
        private GameState currentGameState;

        /// <summary>
        /// State of game. 
        /// </summary>
        public GameState gameState
        {
            get
            {
                return currentGameState;
            }
            set
            {
                currentGameState = value;

                if (value == GameState.GameOver)
                    GameOver();
            }

        }

        private int ballsCounter = 0; // Number of spawned balls
        public int Score = 0;
        public int bestScore;
        public int gamesCount; // Number of played games ever
        public int diamondsCount; // Number of collected diamonds ever (money)

        private int Level = 1;
        private int numOfDiamonds = 0; // Number of spawned diamonds;

        [SerializeField]
        private Text scoreText;
        [SerializeField]
        private Transform gameCanvas;

        [SerializeField]
        private UIManager uiManager;

        [SerializeField]
        private SoundManager soundManager;

        [SerializeField]
        private GameObject diamondPrefab;
        [SerializeField]
        private GameObject diamondOverPrefab;
        [SerializeField]
        private GameObject ballPrefab;
        [SerializeField]
        private GameObject ballOverPrefab;

        [SerializeField]
        private GameObject[] Bouncers;

        private List<GameObject> listDiamonds = new List<GameObject>();
        private List<GameObject> listBalls = new List<GameObject>();

        /* Background Colors */
        [SerializeField]
        private Color32[,] gameColors = new Color32[9, 2] {
        { new Color32(109, 109, 109, 255), new Color32(219, 219, 219, 255) }, // Grey
        { new Color32(155, 119, 224, 255), new Color32(239, 229, 255, 255) }, // Purple
        { new Color32(81,  233, 223, 255), new Color32(200, 255, 252, 255) }, // Green-Blue
        { new Color32(253, 188,  69, 255), new Color32(251, 237, 225, 255) }, // Yellow-Orange
        { new Color32(118, 218, 109, 255), new Color32(226, 249, 228, 255) }, // Green
        { new Color32(255, 132, 208, 255), new Color32(253, 232, 253, 255) }, // Pink
        { new Color32(249,  97,  63, 255), new Color32(254, 226, 204, 255) }, // Red-Orange
        { new Color32(254, 254, 254, 255), new Color32(55,   55,  55, 255) }, // Black
        { new Color32(83,  168, 251, 255), new Color32(218, 236, 255, 255) }, // Black
    };

        [SerializeField]
        private Sprite[] diamondSprites = new Sprite[4];
        [SerializeField]
        private Color32[] diamondOverTextColors;

        [SerializeField]
        private Gradient[] diamondOverParticleGradients;

        [SerializeField]
        private Camera cam;
        [SerializeField]
        private Image[] background;

        [SerializeField]
        private RectTransform rightSpawnPoint;
        [SerializeField]
        private RectTransform leftSpawnPoint;

        [SerializeField]
        private FlippersBehaviour flippersBehaviour;
        #endregion

        // Use this for initialization
        void Start()
        {
            gameState = GameState.Prepare;

            /* Load saved values */
            if (PlayerPrefs.HasKey("BestScore"))
                bestScore = PlayerPrefs.GetInt("BestScore");
            else
                bestScore = 0;

            if (PlayerPrefs.HasKey("GamesCount"))
                gamesCount = PlayerPrefs.GetInt("GamesCount");
            else
                gamesCount = 0;

            if (PlayerPrefs.HasKey("DiamondsCount"))
                diamondsCount = PlayerPrefs.GetInt("DiamondsCount");
            else
                diamondsCount = 0;
        }

        private void Awake()
        {
            Application.targetFrameRate = 60;
        }


        /// Start game
        public void StartGame()
        {
            Score = 00;
            Level = 1;
            scoreText.text = "00";


            StartCoroutine(StartFlippersBehaviour());

            gameState = GameState.Playing;
            NewDiamond();
            NewBall();
        }

        /*flippers' behavior with delay*/
        IEnumerator StartFlippersBehaviour()
        {
            yield return new WaitForSecondsRealtime(0.1f);
            flippersBehaviour.enabled = true;
        }

        /// Initiates end of game. (defeat)
        private void GameOver()
        {
            soundManager.GameOver();

            if (Score > bestScore)
            {
                bestScore = Score;
            }

            /* Destroy the remaining diamonds and balls */
            foreach (GameObject diamond in listDiamonds)
            {
                DestroyDiamond(diamond);
            }
            foreach (GameObject ball in listBalls)
            {
                ballsCounter--;

                GameObject ballParticle = Instantiate(ballOverPrefab, ball.transform.position, new Quaternion(), gameCanvas);
                Destroy(ball);
                Destroy(ballParticle, 1.5f);
            }

            /* Clear lists with diamonds and balls for next games */
            listDiamonds.Clear();
            listBalls.Clear();

            gamesCount++;

            Save();

            flippersBehaviour.enabled = false;
            StartCoroutine(ShowUserInterface());
        }

        /* Shows user interface with delay for waiting to complete visual effects */
        IEnumerator ShowUserInterface()
        {
            yield return new WaitForSecondsRealtime(0.5f);
            uiManager.ShowGameOverUI();
        }

        #region Diamond Beahviour
        /// <summary>
        /// Create new diamond.
        /// </summary>
        /// <param name="prevDiamond"></param>
        public void NewDiamond(GameObject prevDiamond = null)
        {
            if (prevDiamond != null)
            {
                DestroyDiamond(prevDiamond);

                /* Update score */
                Score += Level;
                scoreText.text = Score.ToString();
            }

            #region Diamond's Events
            if (Level == 1)
            {
                if (Score == 10)
                {
                    Bouncers[0].SetActive(true);
                }
                if (Score == 15)
                {
                    Bouncers[1].SetActive(true);
                    Bouncers[2].SetActive(true);
                }

                if (Score == 20)
                {
                    NewBall();
                }
            }

            if (Score == 120)
            {
                NewBall();
            }

            if (Score % 30 == 0 && Score != 0)
            {
                if (Level < 4) // only 4 levels in game
                    Level++;

                NewBall();
            }
            #endregion

            if (Score >= 20)
            {
                if (numOfDiamonds == 0)
                {
                    InstantiateDiamond();
                    InstantiateDiamond();
                }
            }
            else
            {
                InstantiateDiamond();
            }

            ChangeBackgroundColor();
        }

        /// <summary>
        /// Changes background color.
        /// </summary>
        private void ChangeBackgroundColor()
        {
            if ((Score / Level) % 5 == 0 && Score != 0)
            {
                int randomColorNum = Random.Range(0, 8);

                for (int i = 0; i < background.Length; i++)
                {
                    background[i].color = gameColors[randomColorNum, 0];
                }
                cam.backgroundColor = gameColors[randomColorNum, 1];
            }
        }

        /// <summary>
        /// Instantiate new diamond.
        /// </summary>
        private void InstantiateDiamond()
        {
            numOfDiamonds++;
            Vector2 randomPos = GetRandomPosition();
            GameObject newDiamond = Instantiate(diamondPrefab, randomPos, new Quaternion(), gameCanvas);
            newDiamond.GetComponent<Image>().sprite = diamondSprites[Level - 1];
            newDiamond.name = "Diamond (Clone)";
            listDiamonds.Add(newDiamond);
        }

        /// <summary>
        /// Calculate random position of new diamond.
        /// </summary>
        /// <returns></returns>
        private Vector2 GetRandomPosition()
        {
            Vector2 randomPos = new Vector2(0.0f, 0.0f);
            const float radius = 1.7f;
            Vector2 center = new Vector2(0.0f, 2.0f);
            float angle = Random.value;

            bool validPosition = false;
            while (!validPosition)
            {
                /* Get random position in a preset circle */
                randomPos.x = center.x + Random.Range(0.0f, radius) * Mathf.Cos(angle * Mathf.Rad2Deg);
                randomPos.y = Random.Range(center.y, 0.5f) + Random.Range(0.0f, radius) * Mathf.Sin(angle * Mathf.Rad2Deg);

                /* Check overlap */
                if (CheckOverlap(randomPos))
                    validPosition = true;
            }

            return randomPos;
        }

        /// <summary>
        /// Check overlap with bouncer
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private bool CheckOverlap(Vector2 position)
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(position, 0.22f);
            foreach (Collider2D col in colliders)
            {
                if (col.tag == "Bouncer" || col.tag == "Background")
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Destroys diamond.
        /// </summary>
        /// <param name="prevDiamond"></param>
        private void DestroyDiamond(GameObject prevDiamond)
        {
            /* Particle Effect */
            GameObject diamondParticle = Instantiate(diamondOverPrefab, prevDiamond.transform.position, new Quaternion(), gameCanvas);

            if (currentGameState == GameState.GameOver)
            {
                diamondParticle.transform.Find("Text").gameObject.SetActive(false); // No score if is GameOver            
            }
            else
            {
                /* +Score Text Effect */
                diamondParticle.transform.Find("Text").GetComponent<Text>().text = "+" + Level.ToString();
                diamondParticle.transform.Find("Text").GetComponent<Text>().color = diamondOverTextColors[Level - 1];

                listDiamonds.Remove(prevDiamond);
            }
            /* Set Diamond Destroy color of Particle System */
            ParticleSystem.MainModule main = diamondParticle.GetComponent<ParticleSystem>().main;
            ParticleSystem.MinMaxGradient grad = new ParticleSystem.MinMaxGradient(diamondOverParticleGradients[Level - 1]);
            grad.mode = ParticleSystemGradientMode.RandomColor;
            main.startColor = grad;

            Destroy(diamondParticle, 1.25f);
            numOfDiamonds--;
            Destroy(prevDiamond);
        }

        #endregion

        #region Ball Behaviour

        /// Creates new ball.
        public void NewBall()
        {
            /* Choosing side of spawn */
            int randomValue = Random.Range(-1, 2);
            Vector2 pos;
            if (randomValue == -1)
                pos = leftSpawnPoint.position;
            else
                pos = rightSpawnPoint.position;

            /* Instantiate ball */
            ballsCounter++;
            GameObject newBall = Instantiate(ballPrefab, (pos), new Quaternion(), gameCanvas);
            listBalls.Add(newBall);
        }


        /// Destroys ball.
        /// <param name="ball"></param>
        public void DestroyBall(GameObject ball)
        {
            ballsCounter--;
            if (ballsCounter > 0)
            {
                listBalls.Remove(ball);

                /* Destroy Particle Effect*/
                GameObject ballParticle = Instantiate(ballOverPrefab, ball.transform.position, new Quaternion(), gameCanvas);
                Destroy(ball);
                Destroy(ballParticle, 1.5f);
            }
            else // no more balls
            {
                if (gameState != GameState.GameOver)
                    gameState = GameState.GameOver;
            }
        }
        #endregion

        /// Saves game values. 
        private void Save()
        {
            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.SetInt("GamesCount", gamesCount);
            PlayerPrefs.SetInt("DiamondsCount", diamondsCount);
        }

    }
}
