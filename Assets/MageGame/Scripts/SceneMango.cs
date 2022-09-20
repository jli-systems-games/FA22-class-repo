using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace maiproject
{
    public class SceneMango : MonoBehaviour
    {
        public Scene sampleScene;
        public AudioSource Click;
        public float timer = 0.1f;
        public string switchSceneWhenSoundIsOver = "";
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if( (switchSceneWhenSoundIsOver!="") && !Click.isPlaying) {
                SceneManager.LoadScene(switchSceneWhenSoundIsOver);
                switchSceneWhenSoundIsOver = "";
            }
        }

        public void PlayBtn(string game)
        {


            Click.Play();
            switchSceneWhenSoundIsOver = game;
            
           
        }

        public void closeApp()
        {
            
            Click.Play();
            if (!Click.isPlaying)
            {
                Application.Quit();
            }
        }
    }
}