using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MaxArcade
{

    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject GameOverUI;
        [SerializeField]
        private GameObject HomeUI;

        [SerializeField]
        private GameManager gameManager;

        [SerializeField]
        private Text gameOverScoreText; // Score on GameOver
        [SerializeField]
        private Text gameOverBestScoreText; // Best Score on GameOver
        [SerializeField]
        private Text diamondsCounterText; // All diamonds text (text of money)
        [SerializeField]
        private Text gamesCounterText; // Number of games played

        // Start is called before the first frame update
        void Start()
        {
            ShowHomeUI();

        }

        // Update is called once per frame
        void Update()
        {
            if (gameManager.gameState == GameManager.GameState.Prepare)
            {
                #region UNITY_EDITOR
#if UNITY_EDITOR
            if (Input.GetMouseButtonDown(0))
            {
                StartGameButton();
            }
#endif
                #endregion

                #region TOUCH
#if !UNITY_EDITOR
                if (Input.touchCount > 0)
                {
                    for (int i = 0; i < Input.touchCount; i++)
                    {
                        Touch touch = Input.GetTouch(i);

                        if (touch.phase == TouchPhase.Ended)
                        {
                            StartGameButton();
                        }
                    }
                }
#endif
                #endregion
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                ScreenCapture.CaptureScreenshot("D:/1.png");
            }
        }

        /// <summary>
        /// Calls StartGame function and hides user interface.
        /// </summary>
        public void StartGameButton()
        {
            HideUserInterface();
            gameManager.StartGame();
        }

        /// <summary>
        /// Hides all user interface.
        /// </summary>
        private void HideUserInterface()
        {
            HideGameOverUI();
            HideHomeUI();
        }

        /// <summary>
        /// Displays GameOver user interface.
        /// </summary>
        public void ShowGameOverUI()
        {
            GameOverUI.SetActive(true);

            /* Update values on screen */
            gameOverScoreText.text = gameManager.Score.ToString();
            gameOverBestScoreText.text = gameManager.bestScore.ToString();
        }

        /// <summary>
        /// Hides GameOver user interface.
        /// </summary>
        public void HideGameOverUI()
        {
            GameOverUI.SetActive(false);
            gameManager.gameState = GameManager.GameState.Prepare;
        }

        /// <summary>
        /// Displays Home user interface.
        /// </summary>
        public void ShowHomeUI()
        {
            HomeUI.SetActive(true);

            /* Update values on screen */
            gamesCounterText.text = gameManager.gamesCount.ToString();
            diamondsCounterText.text = gameManager.diamondsCount.ToString();
        }

        /// <summary>
        /// Hides Home user interface.
        /// </summary>
        public void HideHomeUI()
        {
            HomeUI.SetActive(false);
        }
    }
}
