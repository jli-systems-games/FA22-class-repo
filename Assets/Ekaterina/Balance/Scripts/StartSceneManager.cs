using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ekaterina
{
    public class StartSceneManager : MonoBehaviour
    {
        public Button start;

        void Start()
        {
            Button btn = start.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick()
        {
            SceneManager.LoadScene("Ekaterina.Balance.Main scene");
            Debug.Log("Clicked");
        }
    }
}
