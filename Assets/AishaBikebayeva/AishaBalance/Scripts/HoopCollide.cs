using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace AishasCircus{

    public class HoopCollide : MonoBehaviour
    {
        // public GameObject disappear;
        public GameObject gameOverScene;

        public void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "Obstacle")
            {
                //Destroy(other.gameObject);
                Debug.Log("hit detected");
                // GameObject e = Instantiate(disappear) as GameObject;
                // e.transform.position = transform.position;
                // gameOverScene.enabled = true;
                Time.timeScale = 0;
                gameOverScene.SetActive(true);
                // SceneManager.LoadScene("GameOverCircus");
            }
            
            
            //if (other.gameObject.tag == "Enemy")
            //{
            //    Destroy(gameObject);
            //}
        }
    }
}