using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace AishaLifelike
{
    public class ChangeSceneOpening : MonoBehaviour
    {
        private bool isLoading;
        public TMP_Text text;
        public AudioSource playSound;

        public void restartScene()
        {
            //CoinPicker.coin = "Coins: " + coin.ToString();
            //playSound.Play();
            // Use a coroutine to load the Scene in the background
            StartCoroutine(LoadYourAsyncScene());
        }


        IEnumerator LoadYourAsyncScene()
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("OpeningScene");

            // Wait until the asynchronous scene fully loads
            while (!asyncLoad.isDone)
            {
                if (isLoading == false)
                {
                    Debug.Log("Loading");
                    isLoading = true;
                    text.enabled = true;
                }

                yield return null;

            }
        }
    }
}