using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace EkaterinaFunButton
{
    public class FunObject : MonoBehaviour
    {
        // a float to store the lifetime in seconds of the object
        private float Lifetime{ get; set; }
        private float Speed{ get; set; }

        private float _timeAlive;
        
        public void Initialize(float lifeTime, float speed)
        {
            Lifetime = lifeTime;
            Speed = speed;
            _timeAlive = 0f;
            //this object does not keep track of its direction, it is always moving "up"
            //the creation process in FunSystem will rotate it
            
            StartCoroutine(CountdownLife());
        }

        // Simply counts down the life until it dies
        private IEnumerator CountdownLife()
        {
            while (_timeAlive < Lifetime)
            {
                _timeAlive += Time.deltaTime;
                transform.localPosition += transform.up * (Speed * Time.deltaTime); //move "up"
                yield return null;
            }
            
            Destroy(gameObject);
        }
    }
}