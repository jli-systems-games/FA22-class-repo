using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana

{

    public class Reset : MonoBehaviour
    {
        public void ResetGame()
        {
            SceneManager.LoadScene("ToyBox");

        }
    }

}
