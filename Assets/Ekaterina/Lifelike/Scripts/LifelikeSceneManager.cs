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
            if (collider.gameObject.name == "Crab")
            {
                SceneManager.LoadScene("Ekaterina.Lifelike.Lose");
            }
            
            if (collider.gameObject.name == "Mutant")
            {
                SceneManager.LoadScene("Ekaterina.Lifelike.Lose");
            }
            
            if (collider.gameObject.name == "Slider")
            {
                SceneManager.LoadScene("Ekaterina.Lifelike.Lose");
            }
            
            if (collider.gameObject.name == "Portal")
            {
                SceneManager.LoadScene("Ekaterina.Lifelike.Story_4");
            }
        }
    }
}
    

