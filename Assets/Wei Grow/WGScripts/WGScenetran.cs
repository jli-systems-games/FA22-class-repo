using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



namespace Bloom
{


    public class WGScenetran : MonoBehaviour
    {

      public void SceneTran()
        {
            SceneManager.LoadScene("WG_scence1");
        }


        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}