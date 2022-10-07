using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simon.Project2.Scripts
{
    public class EnemyScroller : MonoBehaviour
    {

        public float beatTempo;
        public bool hasStarted;
        
        void Start()
        {
            beatTempo = beatTempo / 60f;
        }

        void Update()
        {
            if (!hasStarted)
            {
                // if (Input.anyKeyDown)
                // {
                //     hasStarted = true;
                // }
            }
            else
            {
                transform.position -= new Vector3(-beatTempo * Time.deltaTime, 0f, 0f);
            }
        }
    }

}