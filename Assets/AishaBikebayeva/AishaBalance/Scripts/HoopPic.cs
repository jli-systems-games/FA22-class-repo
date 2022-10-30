using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

namespace AishasCircus
{
    public class HoopPic : MonoBehaviour
    {
        CircusScore score;
        PlayerClown clown;
        //gameOverScreen gameOverScreen;

        private SpriteRenderer sr;
        private float fallSpeed = 200; //f;
        //private Image customImage;

        void Start()
        {

            sr = this.GetComponent<SpriteRenderer>();
            score = GameObject.Find("Score").GetComponent<CircusScore>();//fill the scoreManager variable with a reference to the Score Manager
            clown = GameObject.Find("Clown").GetComponent<PlayerClown>(); //fill player Variable with reference to Player
        }

        void Update()
        {
        transform.position += new Vector3(-fallSpeed * Time.deltaTime, 0, 0);
        }

        void OnTriggerEnter2D(Collider2D otherCollider)
        {
            if(otherCollider.gameObject.tag == "Player")
            {
                Destroy(this.gameObject);
                this.gameObject.SetActive(false);
                Debug.Log("Oh no! Objects collided");
                SceneManager.LoadScene("GameOverCircus");
            }
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