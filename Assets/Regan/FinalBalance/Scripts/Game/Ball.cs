using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Regan.Balance
{
    

    public class Ball : MonoBehaviour
    {
        public delegate void CollectionDelegate(int amount);
        public static event CollectionDelegate OnCollect;

        public delegate void DeathDelegate();
        public static event DeathDelegate OnDeath;

        public delegate void WinDelegate();
        public static event WinDelegate OnWin;

        private void Update()
        {
            if (transform.position.y > -100) return;
            Kill();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            

            if (collision.CompareTag("Regan.balance.collectable")) 
            {
                Destroy(collision.gameObject);
                OnCollect?.Invoke(1);           
                return;
            }

            if (collision.CompareTag("Regan.balance.finish"))
            {
                Win();
                return;
            }

            if (!collision.CompareTag("Regan.balance.obstacle")) return;
            Kill();
        }

        private async void Kill()
        {
            Destroy(gameObject);
            OnDeath?.Invoke();

            await Task.Delay(2000);

            SceneManager.LoadScene("Regan.Balance.Menu");
        }
        private async void Win()
        {

            OnWin?.Invoke();
            await Task.Delay(2000);

            SceneManager.LoadScene("Regan.Balance.Menu");
        }



    }
}
