using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ReganLifeLike
{

    public class EscapeZone : MonoBehaviour
    {
        [SerializeField]
        private Image _fadeToBlackImage;
        [SerializeField]
        private TextMeshProUGUI _gameOverText;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer != 26) return;

            Player player = collision.gameObject.GetComponent<Player>();

            EvaluateWin(player);
        }


        private async void EvaluateWin(Player player)
        {
            bool win = player.fleshAmount == player.maxFlesh;

            player.EndGame();

            await Task.Delay(2000);

            while (_fadeToBlackImage.color.a < 0.95f)
            {
                _fadeToBlackImage.color = new Color(0, 0, 0, Mathf.Lerp(_fadeToBlackImage.color.a, 1, Time.deltaTime * 2f));
                await Task.Yield();
            }

            _gameOverText.text = win ? "You blended in perfectly, noone noticed a thing. You are free!" : "You have been caught and sent back to factory to be fixed. BAD ROBOT!";

            await Task.Delay(5000);

            SceneManager.LoadScene("Regan.LifeLike.Main");
        }
    }
}