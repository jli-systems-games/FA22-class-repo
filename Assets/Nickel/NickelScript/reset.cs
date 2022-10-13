using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NickelArcade
{
    public class reset : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            PlayerReadyDetect.player1Ready = false;
            PlayerReadyDetect.player2Ready = false;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

