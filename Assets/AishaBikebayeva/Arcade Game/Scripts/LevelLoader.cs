using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Aisha
{
    public class LevelLoader : MonoBehaviour
    {
        public Animator transition;
        public float transitionTime = 1f;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                LoadNextLevel();
            }
        }

        public void LoadNextLevel()
        {
            // StartCoroutine(LoadLevel(SceneManager.LoadScene("Game Over")));
        }

        IEnumerator LoadLevel()
        {
            //play animation
            transition.SetTrigger("Start");
            //wait
            yield return new WaitForSeconds(1);
            //load scene
            SceneManager.LoadScene("Game Over");
        }
    }
}