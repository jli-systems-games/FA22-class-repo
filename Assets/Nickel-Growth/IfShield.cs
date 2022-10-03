using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace nickelGrowth
{
    public class IfShield : MonoBehaviour
    {
        // Start is called before the first frame update

        private bool isShielded = false;
        public GameObject player;
        private float distance1=20;
        private float distance2=20;
        private float distance3=20;
        private float distance4=20;

        public GameObject LH1;
        public GameObject LH2;
        public GameObject LH3;
        public GameObject LH4;

        public TMP_Text buffShow;

        void Start()
        {
            buffShow.text = " ";
        }

        // Update is called once per frame
        void Update()
        {
            if (LH1.activeSelf)
            {
                distance1 = Vector3.Distance(player.transform.position, LH1.transform.position);
            }
            if (LH2.activeSelf)
            {
                distance2 = Vector3.Distance(player.transform.position, LH2.transform.position);
            }
            if (LH3.activeSelf)
            {
                distance3 = Vector3.Distance(player.transform.position, LH3.transform.position);
            }
            if (LH4.activeSelf)
            {
                distance4 = Vector3.Distance(player.transform.position, LH4.transform.position);
            }

                
            if (distance1 < 18 || distance2 < 18 || distance3 < 18 || distance4 < 18)
            {
                Torch.torchStartTiming = false;
                isShielded = true;
                buffShow.text = "The Blessing of God of Light: Torch duration won't reduce near the temple/Reborn in lighted temple";
            }
            else if (distance1 > 18 && distance2 > 18 && distance3 > 18 && distance4 > 18)
            {
                Torch.torchStartTiming = true;
                isShielded = false;
                buffShow.text = " ";
            }
            Debug.Log(isShielded);
        }


    }

}
