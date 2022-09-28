using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Max
{

    public class LevelMove : MonoBehaviour
    {
        public int sceneBuildIndex;

        //Move game to another scene
        private void OnTriggerEnter2D(Collider2D other)
        {
            print("Trigger Entered");

            if (other.tag == "Player")
            {
                print("Switched Scene to " + sceneBuildIndex);
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
        }
    }
}
