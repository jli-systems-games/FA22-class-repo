using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Mariana
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(string scene)
        {
            SceneManager.LoadScene(scene);
        }

    }
}

