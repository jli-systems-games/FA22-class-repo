using UnityEngine;

namespace samantha_zak.Lifelike_2.Scripts
{
    public class FPSLimiter : MonoBehaviour
    {
        [Header("For development testing purposes only")]
        public bool limitFPS = false;
        public int targetFPS = 60;

        void Start()
        {
            if (limitFPS)
            {
                Application.targetFrameRate = targetFPS;
            }
        }
    }
}