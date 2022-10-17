using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MarioLifelike
{

    public class ContinueButton : MonoBehaviour
    {
        public void loadScene()
        {
            SceneManager.LoadScene("MarioLifelikeGameplay");
        }
    }
}