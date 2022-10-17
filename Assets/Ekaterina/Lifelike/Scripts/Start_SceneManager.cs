using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina {


public class Start_SceneManager : MonoBehaviour
{
 void Update ()
    {
    if (Input.GetKeyDown("space")) {
        SceneManager.LoadScene("Ekaterina.Lifelike.Story_1");
    }
}
}
}
