using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

namespace Aisha
{
    public class StonePic : MonoBehaviour
    {
        Score Score;
        boat boat;
        //gameOverScreen gameOverScreen;

        private SpriteRenderer sr;
        private float fallSpeed = 5; //f;
        //private Image customImage;

        void Start()
        {

            sr = this.GetComponent<SpriteRenderer>();
            Score = GameObject.Find("Score").GetComponent<Score>();//fill the scoreManager variable with a reference to the Score Manager
            boat = GameObject.Find("Boat").GetComponent<boat>(); //fill player Variable with reference to Player
        }

        void Update()
        {
        transform.position += new Vector3(-fallSpeed * Time.deltaTime, 0, 0);
        }

        void OnTriggerEnter2D(Collider2D otherCollider)
        {
                Destroy(this.gameObject);
                this.gameObject.SetActive(false);
                Debug.Log("Oh no! Objects collided");
                SceneManager.LoadScene("GameOver");
        }
        public void StoneHit()
        {
            //sr.sprite = Explosion;
            //changes the sprite on the SpriteRenderer component
        }

        public void StoneMissed()
        {

        }
    }
}