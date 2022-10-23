using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioGrowth
{
    public class Run : MonoBehaviour
    {
        public float speed = 10.0f;

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}