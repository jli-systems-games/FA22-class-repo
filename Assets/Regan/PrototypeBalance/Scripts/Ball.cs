using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Regan.Balance
{
    

    public class Ball : MonoBehaviour
    {

        private void Update()
        {
            if (transform.position.y > -100) return;
            Kill();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag("Regan.balance.obstacle")) return;
            Kill();
        }

        private async void Kill()
        {
            Destroy(gameObject);

            await Task.Delay(2000);

            SceneManager.LoadScene("Regan.Balance.Menu");
        }
    }
}
