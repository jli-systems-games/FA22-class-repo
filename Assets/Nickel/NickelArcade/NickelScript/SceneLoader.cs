using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nickel.NickelArcade.NickelScript
{
    public class SceneLoader : MonoBehaviour
    {

        public float time;
        public int sceneNum;

        public GameObject blackout;

        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(PlayerReadyDetect.player1Ready);
            if (PlayerReadyDetect.player1Ready && PlayerReadyDetect.player2Ready)
            {
                blackout.SetActive(true);
                StartCoroutine(LoadLevelAfterDelay(time));




            }
        }



        IEnumerator LoadLevelAfterDelay(float time)
        {
            yield return new WaitForSeconds(time);
            SceneManager.LoadScene("ArcadeMain");

        }


    }
}

