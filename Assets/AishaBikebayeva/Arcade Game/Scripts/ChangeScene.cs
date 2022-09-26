using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Aisha
{
        
    public class ChangeScene : MonoBehaviour
    {
        void Update()
        {
        if (Input.anyKey)
            {
            SceneManager.LoadScene("Play");
            }
        }
        // private bool isLoading;
        // public TMP_Text text;

        // //private void Start()
        // //{
        // //    Cursor.lockState = CursorLockMode.None;
        // //}

        // public void restartScene()
        // {
        //     // Use a coroutine to load the Scene in the background
        //     StartCoroutine(LoadYourAsyncScene());
        // }


        // IEnumerator LoadYourAsyncScene()
        // {
        //     // The Application loads the Scene in the background as the current Scene runs.
        //     // This is particularly good for creating loading screens.
        //     // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        //     // a sceneBuildIndex of 1 as shown in Build Settings.

        //     AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Play");

        //     // Wait until the asynchronous scene fully loads
        //     while (!asyncLoad.isDone)
        //     {
        //         if (isLoading == false)
        //         {
        //             Debug.Log("Loading");
        //             isLoading = true;
        //             text.enabled = true;
        //         }

        //         yield return null;

        //     }
        // }
    }

}