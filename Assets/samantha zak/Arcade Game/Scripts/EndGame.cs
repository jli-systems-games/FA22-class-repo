using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EndGame"))
        {

            Destroy(collision.gameObject);
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("EndGame");
    }
}
