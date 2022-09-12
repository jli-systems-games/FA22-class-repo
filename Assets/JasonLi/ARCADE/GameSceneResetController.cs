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
            _inputs.BackspaceButton += Reset;
        }

        void OnDisable()
        {
            _inputs.BackspaceButton -= Reset;
        }

        void Reset()
        {
            Debug.Log("Attempting Reset");
            SceneManager.LoadScene("JasonLi/ARCADE/BasicScene");
        }
    }
}