using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Simon.Project2.Scripts
{
    public class SceneReloader : MonoBehaviour
    {
        void Start()
        {
        
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
            } 
        }

       
    }

}
