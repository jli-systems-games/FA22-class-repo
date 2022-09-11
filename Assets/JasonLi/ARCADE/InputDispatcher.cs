using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JasonLi
{
    public class InputDispatcher : MonoBehaviour
    {
        public Action PrimaryButton;
        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("PrimaryButton"))
            {
                PrimaryButton?.Invoke();
            }
        }
    }
}