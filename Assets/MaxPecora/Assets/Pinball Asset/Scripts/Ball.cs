using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Spikes")
        {
            gameManager.DestroyBall(gameObject);
        }
    }
}
