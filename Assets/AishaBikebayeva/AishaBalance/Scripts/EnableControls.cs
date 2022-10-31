using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AishasCircus{
    public class EnableControls : MonoBehaviour
    {

        public GameObject gameOverScene;
        public Button button;
        // Start is called before the first frame update

        void Start () {
            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick(){
            gameOverScene.SetActive(true);
            // gameOverScene.transform.position = new Vector2(10, 0);
        }
    }
}