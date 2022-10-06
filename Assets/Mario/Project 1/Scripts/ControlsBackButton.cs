using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace MarioArcadeSoccer
{

    public class ControlsBackButton : MonoBehaviour
    {
        public void loadScene()
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
}