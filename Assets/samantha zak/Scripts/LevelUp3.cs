using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp3 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LevelUp3"))
        {

            Destroy(collision.gameObject);
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("SamPinballWorkshop");
    }
	
    /* IEnumerator LoadLeveller()
     {
         //wait time
         yield return new WaitForSeconds(1);
         LoadLevel();
     }
     
 */
}