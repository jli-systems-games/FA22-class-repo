using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioLifelike
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager instance;

        [SerializeField] private GameObject hiddenObjectIconHolder;
        [SerializeField] private GameObject hiddenObjectIconPrefab;
        [SerializeField] private GameObject gamepanel;

        private void Awake()
        {
            if (instance == null) instance = this;
            else if (instance != null) Destroy(gameObject);
        }
    }
}