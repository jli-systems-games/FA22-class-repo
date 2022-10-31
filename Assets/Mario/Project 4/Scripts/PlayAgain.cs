using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MarioBalance
{
    public class PlayAgain : MonoBehaviour
    {
        public void loadScene()
        {
            SceneManager.LoadScene("MarioBalanceTitleScreen");
        }
    }
}