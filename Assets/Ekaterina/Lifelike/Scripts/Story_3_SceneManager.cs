using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina {


public class Story_3_SceneManager : MonoBehaviour
{
 void Update ()
    {
    if (Input.GetKeyDown("space")) {
        SceneManager.LoadScene("Ekaterina.Lifelike.Main scene");
    }
}
}
}
