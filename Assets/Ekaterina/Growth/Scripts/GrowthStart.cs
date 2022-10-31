using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Ekaterina
{
    public class GrowthStart : MonoBehaviour
    {
        public Button start;

        void Start()
        {
            Button btn = start.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick()
        {
            SceneManager.LoadScene("Ekaterina.Growth.Main scene");
        }
    }
}
