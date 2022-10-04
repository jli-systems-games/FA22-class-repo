using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana

{

    public class FirstSceneLoad : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("Island1");

        }
    }

}