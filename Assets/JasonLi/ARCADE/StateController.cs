using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JasonLi
{
    public class GameSceneResetController : MonoBehaviour
    {
        [SerializeField] private InputDispatcher _inputs;

        void OnEnable()
        {
            _inputs.TildeButton += Reset;
        }

        void OnDisable()
        {
            _inputs.TildeButton -= Reset;
        }

        void Reset()
        {
            SceneManager.LoadScene("JasonLi/ARCADE/BasicScene");
        }
    }
}