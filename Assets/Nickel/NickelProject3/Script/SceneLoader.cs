using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace nickelLifelike
{
    public class SceneLoader : MonoBehaviour
    {
        public bool backToStart;
        // Start is called before the first frame update
        void Start()
        {
            if (!backToStart)
            {
                SceneManager.LoadScene("Lifelike1");
            }
            else if(backToStart)
            {
                //Debug.Log("clicked");
                SceneManager.LoadScene("Nickel3Start");
            }
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
