using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using MunroHobermanPinball;

namespace MunroHobermanPinball {
    public class PinballBumper : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameController.instance.AddScore(1);
        }
    }
}