using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina {


public class Win : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.name == "exit") {
        SceneManager.LoadScene("Win");
    }
}
}
}
