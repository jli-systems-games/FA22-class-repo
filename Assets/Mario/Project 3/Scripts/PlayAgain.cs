using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MarioLifelike
{

    public class PlayAgain : MonoBehaviour
    {
        public void loadScene()
        {
            SceneManager.LoadScene("MarioLifelikeTitleScreen");
        }
    }
}