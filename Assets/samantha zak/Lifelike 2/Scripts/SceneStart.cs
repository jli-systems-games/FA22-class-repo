using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sam
{
    public class SceneStart : MonoBehaviour
    {

        public void PlayGame()
        {
            SceneManager.LoadScene("Main");
        }

        public void Exit()
        {
            SceneManager.LoadScene("Menu");
        }

        /*public void Controls()
        {
            SceneManager.LoadScene("Controls Page");
        }
        */


    }
}