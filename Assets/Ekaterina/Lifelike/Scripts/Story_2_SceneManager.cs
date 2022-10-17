using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina {


public class Story_2_SceneManager : MonoBehaviour
{
 void Update ()
    {
    if (Input.GetKeyDown("space")) {
        SceneManager.LoadScene("Ekaterina.Lifelike.Story_3");
    }
}
}
}
