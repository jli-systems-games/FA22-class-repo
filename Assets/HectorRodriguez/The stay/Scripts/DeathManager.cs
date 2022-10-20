using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace HectorRodriguez
{

    public class DeathManager : MonoBehaviour
    {
    private void OnTriggerEnter(Collider collider)
        {
            if(collider.gameObject.name == "THING")
            {
                SceneManager.LoadScene("DeathScene");
            }
        }
    }

}