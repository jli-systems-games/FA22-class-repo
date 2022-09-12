using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;


namespace SharedAssets
{
    [CreateAssetMenu(fileName = "New Float Parameter", menuName = "Parameter Object/Float Parameter")]
    public class FloatParameter : ScriptableObject
    {
        [SerializeField] private float _value;

        public float Value
        {
            get { return _value; }
            protected set { _value = value; }
        }

        // Enables you to do math directly on the parameter
        public static implicit operator float(FloatParameter p) => p._value;
    }

}

