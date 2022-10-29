using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace AishasCircus{

    public class HoopCollide : MonoBehaviour
    {
        // public GameObject disappear;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "Obstacle")
            {
                //Destroy(other.gameObject);
                Debug.Log("hit detected");
                // GameObject e = Instantiate(disappear) as GameObject;
                // e.transform.position = transform.position;
                SceneManager.LoadScene("GameOverCircus");
                // CoinPicker.coin = 0;
            }
            
            
            //if (other.gameObject.tag == "Enemy")
            //{
            //    Destroy(gameObject);
            //}
        }
    }
}