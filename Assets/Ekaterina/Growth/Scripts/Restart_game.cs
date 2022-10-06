using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ekaterina
{
    public class Restart_game : MonoBehaviour
    {
        public Button Button;
        void Start () {
            Button btn = Button.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
        void TaskOnClick()
        {
            SceneManager.LoadScene("Ekaterina.Growth.Start");
        }
    }
}