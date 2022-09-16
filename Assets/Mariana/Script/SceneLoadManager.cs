using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana
{
    public class SceneLoadManager : MonoBehaviour
    {

        // Start is called before the first frame update
        public void PlayGame()
        {
            SceneManager.LoadScene("Game");
        }


    }
}
