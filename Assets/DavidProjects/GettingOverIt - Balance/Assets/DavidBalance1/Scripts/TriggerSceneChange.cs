using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DavidBalance1{

public class TriggerSceneChange : MonoBehaviour
{
  public int sceneNumber;

 private void OnTriggerEnter2D(Collider2D other)
 {
            if (other.CompareTag("Player"))
             {
                 SceneManager.LoadScene(sceneNumber);
             }

 }

}
}