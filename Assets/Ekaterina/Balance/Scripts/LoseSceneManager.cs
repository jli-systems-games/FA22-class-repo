using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ekaterina
{

    public class LoseSceneManager : MonoBehaviour
    {
        public Button restart;

        void Start()
        {
            Button btn = restart.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick()
        {
            SceneManager.LoadScene("Ekaterina.Balance.Main scene");
            Debug.Log("Clicked");
        }
    }
}
