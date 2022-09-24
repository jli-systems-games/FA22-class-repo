using UnityEngine;
using UnityEngine.UI;

namespace MaxArcade
{

    public class Diamond : MonoBehaviour
    {
        private GameManager gameManager;
        private SoundManager soundManager;

        [SerializeField]
        private Image Loader;

        private float timeToEnd = 10.0f;

        private void Awake()
        {
            gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
            soundManager = GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>();
        }

        // Use this for initialization
        private void Start()
        {
            timeToEnd = 10.0f;
        }

        // Update is called once per frame
        private void Update()
        {
            if (timeToEnd > 0)
            {
                timeToEnd -= Time.deltaTime;
                Loader.fillAmount = 1 - timeToEnd / 10.0f;
            }
            else
            {
                gameManager.gameState = GameManager.GameState.GameOver;
            }
        }

        /* Check if ball enter in */
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Ball")
            {
                soundManager.DiamondCollect();
                gameManager.diamondsCount++;
                gameManager.NewDiamond(gameObject);
            }
        }
    }
}
