using UnityEngine;

namespace SharedAssets
{
    [CreateAssetMenu(fileName = "New Int Parameter", menuName = "Parameter Object/Int Parameter")]
    public class IntParameter : ScriptableObject
    {
        [SerializeField] private int _value;

        public int Value
        {
            get { return _value; }
            protected set { _value = value; }
        }

        // Enables you to do math directly on the parameter
        public static implicit operator int(IntParameter p) => p._value;
    }
}