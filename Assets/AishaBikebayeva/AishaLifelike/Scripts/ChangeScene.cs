using UnityEngine;
using UnityEngine.SceneManagement;

namespace AishaBikebayeva.AishaLifelike.Scripts
{
        
    public class ChangeScene : MonoBehaviour
    {
        void Update()
        {
        if (Input.anyKey)
            {
            SceneManager.LoadScene("Play");
            }
        }
    }

}