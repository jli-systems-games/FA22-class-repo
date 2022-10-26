using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Bananagodzilla
{


    public class IntroScene : MonoBehaviour
    {
        public Rigidbody2D[] leavables;

        public GameObject[] removables;

        public GameObject[] addables;
        void Start()
        {
            for (int i = 0; i< leavables.Length; i++){
                leavables[i].isKinematic = true;
            }
        }

      

       public  void Off()
        {
            for (int i = 0; i< leavables.Length; i++)
            {
                leavables[i].isKinematic = false;
            }
            
            for (int i = 0; i< removables.Length; i++){
                removables[i].gameObject.SetActive(false);
            }
            
            for (int i = 0; i< addables.Length; i++)
            {
                addables[i].SetActive(true);
            }

        }
    }
}
