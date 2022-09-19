using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace maiproject
{
    public class SceneMango : MonoBehaviour
    {
        public Scene sampleScene;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PlayBtn(string game)
        {
            SceneManager.LoadScene(game);
        }

        public void closeApp()
        {
            Application.Quit();
        }
    }
}