using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Unity.UI;
using UnityEngine.UI;

namespace MunroHobermanPinball
{
    public class GameController : MonoBehaviour
    {
        private static int _score;

        public static GameController instance;

        [SerializeField] private TextMeshProUGUI
        scoreText;
        // Start is called before the first frame update
        void Start()
        {
            instance = this;
        }

        public void AddScore(int amount)
        {
            _score += amount;
            scoreText.text = _score.ToString();

        }
        // Update is called once per frame
        void Update()
        {
        
        }
    }
 
}
