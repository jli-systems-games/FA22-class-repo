using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SharedAssets
{
    public class SceneButtonTarget : MonoBehaviour
    {
        private string _targetSceneName;
        [SerializeField] private TextMeshProUGUI _sceneNameTextObject;

        public void Initialize(string scenePath, string sceneName = null)
        {
            SetTargetSceneName(scenePath, sceneName);
        }
        
        public void LoadTargetScene()
        {
            SceneManager.LoadSceneAsync(_targetSceneName);
        }
        
        private void SetTargetSceneName(string scenePath, string sceneName)
        {
            _targetSceneName = scenePath;
            _sceneNameTextObject.text = sceneName;
        }


    }
}