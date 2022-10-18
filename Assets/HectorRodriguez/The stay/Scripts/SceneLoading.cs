using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HectorRodriguez
{
    public class SceneLoading : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }


        float timer = 2f;

        // Update is called once per frame
        void Update()
        {
            timer = -Time.deltaTime;

            if (timer <= 0)
            {
                timer = 2f;
            }
        }

        public void SwitchScenes()
        {
            if (SceneManager.GetActiveScene().name == "LoadingScreen")
            {
                LoadScene("MainGame");
            }
            if (SceneManager.GetActiveScene().name == "DeathScene")
            {
                LoadScene("LoadingScreen");
            }
            void LoadScene(string name)
            {
                SceneManager.LoadScene(name);
            }
        }
        }
    }