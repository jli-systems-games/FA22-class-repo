using UnityEngine;
using UnityEngine.SceneManagement;

namespace SharedAssets
{
    public class SceneResetController : MonoBehaviour
    {
        private const string _ORIGIN_SCENE_NAME = "Shared.SceneSelector";

        void Awake()
        {
            //Find if instances of this object exist in the scene
            SceneResetController[] instances = FindObjectsOfType<SceneResetController>();
            
            //Destroy object is instances of object exist
            if (instances.Length > 1)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        void ResetToOriginScene()
        {
            SceneManager.LoadScene(_ORIGIN_SCENE_NAME);
        }

        //This is not the most elegant but it will work
        void Update()
        {
            //if the user presses left shift and q, reset the scene
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Q))
            {
                ResetToOriginScene();
            }
        }
    }
}