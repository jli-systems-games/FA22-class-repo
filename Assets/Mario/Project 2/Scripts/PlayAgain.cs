using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MarioGrowth
{

    public class PlayAgain : MonoBehaviour
    {
        public void loadScene()
        {
            SceneManager.LoadScene("GrowthTitleScreen");
        }
    }
}