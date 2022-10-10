using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace AishaLifelike
{
        
    public class ChangeScene : MonoBehaviour
    {
        void Update()
        {
        if (Input.anyKey)
            {
            SceneManager.LoadScene("OpeningScene");
            }
        }
    }

}