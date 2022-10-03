using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MarioGrowth
{

    public class StartButton : MonoBehaviour
    {
        public void loadScene()
        {
            SceneManager.LoadScene("GrowthLevel1");
        }
    }
}