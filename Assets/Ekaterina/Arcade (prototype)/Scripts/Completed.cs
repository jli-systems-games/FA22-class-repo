using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina {


public class Completed : MonoBehaviour
{
 void Update ()
    {
    if (Input.GetKeyDown("space")) {
        SceneManager.LoadScene("Start");
    }
}
}
}
