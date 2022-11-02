using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Regan.Balance
{
    public class MenuManager : MonoBehaviour
    {
        private void Start()
        {
            Cursor.lockState = CursorLockMode.None;
        }

        public void LoadLevel(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
    }

}
