using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{
    
    public class ShowDuration : MonoBehaviour
    {
        private float factor=0.06f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Torch.torchTime > 15)
            {
                transform.localScale = new Vector3(0.6f,0.6f,0.6f);
            }
            else if(Torch.torchTime<15)
                transform.localScale = new Vector3(Torch.torchTime*factor, Torch.torchTime*factor, Torch.torchTime*factor);
        }
    }
}


