using System.Collections.Generic;
using UnityEngine;

namespace SharedAssets
{
    [CreateAssetMenu(fileName = "Student Scene Path Configuration", menuName = "Student Scene Path Configuration", order = 0)]
    public class SceneNameToPathConfiguration : ScriptableObject
    {
        [Header("How to use")]
        [Header("Add your scene name by *path name*")]
        [Header("Example: \"JasonLi/ARCADE/BasicScene\"")]
        [Header("DO NOT USE ONLY THE SCENE NAME")]

        public string arcadeScenePath;
        public string growthScenePath;
        public string lifelikeScenePath;
        public string balanceScenePath;

        [Space] 
        
        [Header("Here you can set custom names for your scenes")]
        public string arcadeSceneName;
        public string growthSceneName;
        public string lifelikeSceneName;
        public string balanceSceneName;

        [Space] 
        
        [Header("And now just add your first name here")]
        public string studentFirstName;
        
        //Initalized when we actually run the scene
        public Dictionary<string, string[]> SceneNameAndPathDictionary { get; private set; }

        //Scene names as keys and fallbacks
        private string _ARCADE_STRING = "Arcade";
        private string _GROWTH_STRING = "Growth";
        private string _LIFELIKE_STRING = "Lifelike";
        private string _BALANCE_STRING = "Balance";
        
        //create a dictionary for us to use to assemble the buttons *later*
        public void Initialize()
        {
            SceneNameAndPathDictionary = new Dictionary<string, string[]>();
            SceneNameAndPathDictionary.Add(_ARCADE_STRING, new string[] {arcadeScenePath, arcadeSceneName});
            SceneNameAndPathDictionary.Add(_GROWTH_STRING, new string[] {growthScenePath, growthSceneName});
            SceneNameAndPathDictionary.Add(_LIFELIKE_STRING, new string[] {lifelikeScenePath, lifelikeSceneName});
            SceneNameAndPathDictionary.Add(_BALANCE_STRING, new string[] {balanceScenePath, balanceSceneName});
        }
    }
}