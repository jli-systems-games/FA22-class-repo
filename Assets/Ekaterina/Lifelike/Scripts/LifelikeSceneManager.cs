using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ekaterina
{
    public class LifelikeSceneManager : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.name == "Alien 1")
            {
                SceneManager.LoadScene("Ekaterina.Lifelike.Lose");
            }
        }
    }
}
    


