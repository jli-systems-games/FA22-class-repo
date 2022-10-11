using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EkaterinaFunButton
{
    public class FunSystem : MonoBehaviour
    {
        [SerializeField] private GameObject _funObject;
        [SerializeField] private FloatParameter _funObjectLifeTime;
        [SerializeField] private FloatParameter _funObjectSpeedMin;
        [SerializeField] private FloatParameter _funObjectSpeedMax;

        //This method merely creates an instance of the fun object.
        public void OnClick()
        {
            Quaternion rotationAxis = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.forward);
            GameObject newFunObject = Instantiate(_funObject, transform.position, rotationAxis, transform);
            
            float randomSpeed = Random.Range(_funObjectSpeedMin.Value, _funObjectSpeedMax.Value);
            newFunObject.GetComponent<FunObject>()?.Initialize(_funObjectLifeTime, randomSpeed);
        }
    }
}