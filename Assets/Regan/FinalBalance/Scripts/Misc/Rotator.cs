using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan.Balance
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField]
        private float _rotateSpeed = 10;


        void Update()
        {
            transform.Rotate(0, 0, _rotateSpeed * Time.deltaTime);
        }
    }

}
