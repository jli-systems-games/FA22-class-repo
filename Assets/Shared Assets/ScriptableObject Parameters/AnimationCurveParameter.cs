using UnityEngine;

namespace SharedAssets
{
    [CreateAssetMenu(fileName = "New AnimationCurve Parameter", menuName = "Parameter Object/AnimationCurve Parameter")]
    public class AnimationCurveParameter : ScriptableObject
    {
        [SerializeField] private AnimationCurve _curve;

        public float Evaluate(float t) => _curve.Evaluate(t);

    }
}