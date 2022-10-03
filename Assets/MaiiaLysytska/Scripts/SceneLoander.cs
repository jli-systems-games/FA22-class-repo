using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace godzillabanana
{
    public class SceneLoander : MonoBehaviour
{
        public Scene gameScene;
        
        
    

    public void PlayBtn(string sceneName)
    {


            SceneManager.LoadScene(sceneName);
      


        }

   
}
}

