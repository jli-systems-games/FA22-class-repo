using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LevelUp"))
        {

            Destroy(collision.gameObject);
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level2");
    }
	
     
}

