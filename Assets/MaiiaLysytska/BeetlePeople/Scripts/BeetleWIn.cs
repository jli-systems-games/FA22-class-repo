using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{

    public class BeetleWIn : MonoBehaviour
    {
        public AnimationControls beetle1;
        public AnimationControls beetle2;
        public GameObject winScreen;

        public MaiMove beetle1Mov;

        public MaiMove beetle2Mov;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            beetle1.WinState();
            beetle2.WinState();
            winScreen.SetActive(true);
            beetle1Mov.IfMoves();
            beetle2Mov.IfMoves();
            
        }
    }
}
