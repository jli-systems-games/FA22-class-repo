using UnityEngine;

namespace SharedAssets
{
    [CreateAssetMenu(fileName = "New String Parameter", menuName = "Parameter Object/String Parameter")]
    public class StringParameter : ScriptableObject
    {
        [SerializeField] private string _value;

        public string Value
        {
            get { return _value; }
            protected set { _value = value; }
        }

        // Enables you to do math directly on the parameter
        public static implicit operator string(StringParameter p) => p._value;
    }
}