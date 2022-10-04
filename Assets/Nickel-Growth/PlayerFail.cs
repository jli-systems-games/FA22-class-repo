using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{
    public class PlayerFail : MonoBehaviour
    {
        
        public GameObject player;
        public CharacterController palayerController;

        public Transform target0;
        public Transform target1;
        public Transform target2;
        public Transform target3;
        public Transform target4;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            if (Torch.torchTime <= 0)
            {
                
                if (LightUp.currentTemple == 0)
                {
                    //tp to startpoint
                    //Debug.Log("gameOver");
                    
                    player.transform.position = target0.position;
                    StartCoroutine(torchTimeReGive());

                }
                else if (LightUp.currentTemple == 1)
                {
                    player.transform.position = target1.position;
                    StartCoroutine(torchTimeReGive());
                }
                else if (LightUp.currentTemple == 2)
                {
                    player.transform.position = target2.position;
                    StartCoroutine(torchTimeReGive());
                }
                else if (LightUp.currentTemple == 3)
                {
                    player.transform.position = target3.position;
                    StartCoroutine(torchTimeReGive());
                }
                else if (LightUp.currentTemple == 4)
                {
                    player.transform.position = target4.position;
                    StartCoroutine(torchTimeReGive());
                }

            }
        }

        IEnumerator torchTimeReGive()
        {
            yield return new WaitForSeconds(3);
            Torch.torchTime = 20;
            //Debug.Log("give!");
        }
    }

}

