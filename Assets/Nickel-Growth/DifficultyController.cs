using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace nickelGrowth
{
    public class DifficultyController : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject player;
        public GameObject guideParticles;
        public TMP_Text debuffShown;
        public TMP_Text timer;

        private float timeleft = 120;



        void Start()
        {
            debuffShown.text = " ";
            timer.text = " ";
        }

        // Update is called once per frame
        void Update()
        {
            if(LightUp.finishedLH == 1)
            {
                guideParticles.SetActive(false);
                debuffShown.text = "Debuff: Unable to see guide light(Permanently)";
                
            }
            else if (LightUp.finishedLH == 2)
            {
                TheFirstPerson.FPSController.sprintEnabled = false;
                debuffShown.text = "Debuff: Unable to see guide light(Permanently)"+"\n"+ "Debuff: Unable to sprint(Permanently)";
            }
            else if (LightUp.finishedLH == 3)
            {
                
                startTiming();
                debuffShown.text = "Debuff: Unable to see guide light(Permanently)" + "\n" + "Debuff: Unable to sprint(Permanently)" + "\n"+
                    "Debuff: The body is gradually eroded by darkness, loss of vision. After 2 minutes, unable to move.";
            }
        }

        void startTiming()
        {
            //Debug.Log(timeleft);
            
            if (timeleft <= 0)
            {
                Torch.torchTime = 0;
                StartCoroutine(torchTimeReGive());
                
            } 
            if(timeleft >0 && Torch.torchTime>0)
            {
                timeleft -= Time.deltaTime;
                updateTimer(timeleft);
            }
            if(timeleft >0 && Torch.torchTime <= 0)
            {
                timeleft = 120;
            }

        }

        IEnumerator torchTimeReGive()
        {
            yield return new WaitForSeconds(3);
            Torch.torchTime += 20;
            //Debug.Log("give!");
            timeleft = 120;
        }

        void updateTimer(float currentTime)
        {
            currentTime += 1;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }

}

