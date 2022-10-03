using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace nickelGrowth
{
    public class SceneLoad : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            SceneManager.LoadScene("DarkSurviver");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

