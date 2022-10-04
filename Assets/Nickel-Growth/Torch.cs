using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{
    public class Torch : MonoBehaviour
    {
        public static float torchTime = 15;
        private float torchTimeLocal;
        public Light torchLight;
        private float speed;

        public static bool torchStartTiming = true;



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            TorchStartTiming();
            Debug.Log(torchTime);
            //StartCoroutine(LoadSubtitles());

            

        }

        void TorchStartTiming()
        {
            if (torchTime > 0 && torchStartTiming)
            {

                torchTime -= Time.deltaTime;


            }
            if (torchTime > 3)
            {
                torchLight.intensity = 1.5f;
            }
            else if (torchTime < 3)
            {
                torchLight.intensity -= Time.deltaTime * 0.5f;
            }
            else if (torchTime < 0)
            {
                //Debug.Log("Game Over");
            }
        }



        //IEnumerator LoadSubtitles()
        //{
        //    yield return new WaitForSeconds(torchTime);

        //    Debug.Log("you die");
        //}
    }

}
