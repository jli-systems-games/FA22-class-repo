using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nickel.NickelArcade.NickelScript
{
    public class RestartGame : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            SceneManager.LoadScene("StartPage");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


