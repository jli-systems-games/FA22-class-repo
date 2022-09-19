using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(1);
    }
}
