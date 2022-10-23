using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SharedAssets
{
    public class SceneButtonCreator : MonoBehaviour
    {
        [SerializeField] private GameObject _sceneButtonPrefab;
        [SerializeField] private Transform SceneButtonContainer;
        [SerializeField] private SceneNameToPathConfiguration _sceneNameToPathConfiguration;
        [SerializeField] private TextMeshProUGUI _nameText;
        
        private const string _FALLBACK_SCENE_PATH = "Shared Assets/Scenes/Shared.SceneSelector";
        void Start()
        {
            // First activate the scene namepath configuration for a dictionary to be made.
            _sceneNameToPathConfiguration.Initialize();
            
            CreateAllSceneButtons();

            SetStudentName();
        }

        void SetStudentName()
        {
            _nameText.text = _sceneNameToPathConfiguration.studentFirstName;
        }

        void CreateAllSceneButtons()
        {
            // Go through the dictionary and create a button with the scene name and path
            foreach (KeyValuePair<string,string[]> sceneNamePathPair in _sceneNameToPathConfiguration.SceneNameAndPathDictionary)
            {
                //Simply reload scene if nothing is available
                string scenePath = sceneNamePathPair.Value[0] == String.Empty ? _FALLBACK_SCENE_PATH : sceneNamePathPair.Value[0];
                string sceneName = sceneNamePathPair.Value[1] == String.Empty ? sceneNamePathPair.Key : sceneNamePathPair.Value[1];
                
                CreateSceneButton(scenePath, sceneName);
            }
        }
        
        void CreateSceneButton(string scenePath, string sceneName)
        {
            GameObject sceneButton = Instantiate(_sceneButtonPrefab, SceneButtonContainer.transform);
            sceneButton.GetComponent<SceneButtonTarget>().Initialize(scenePath,sceneName);
        }
    }
}