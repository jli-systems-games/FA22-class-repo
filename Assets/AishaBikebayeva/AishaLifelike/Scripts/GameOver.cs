using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AishaLifelike
{
    public class GameOver : MonoBehaviour
    {
        //public GameObject blood;
        [SerializeField] private Image blood;
        public AudioSource playSound;
        private float attackTimer = 0;
        private float waitTime = 0.5f;

        void Start()
        {
            playSound = GetComponentInChildren<AudioSource>();
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                blood.enabled = true;
                playSound.Play();

                SceneManager.LoadScene(2);
            }
        }

        //public IEnumerator ChangeToScene(string GameOver)
        //{
        //    yield return new WaitForSeconds(1);
        //    SceneManager.LoadScene(2);
        //}
        //public GameObject disappear;

        //private void OnCollisionEnter(Collision other)
        //{
        //    if (other.gameObject.tag == "Enemy")
        //    {
        //        //Destroy(other.gameObject);
        //        Debug.Log("hit detected");
        //        GameObject e = Instantiate(disappear) as GameObject;
        //        e.transform.position = transform.position;
        //        SceneManager.LoadScene("GameOver");
        //        //CoinPicker.coin = 0;
        //    }
        //}

    }


}