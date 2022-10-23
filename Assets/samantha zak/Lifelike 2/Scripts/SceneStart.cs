using UnityEngine;
using UnityEngine.SceneManagement;

namespace samantha_zak.Lifelike_2.Scripts
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