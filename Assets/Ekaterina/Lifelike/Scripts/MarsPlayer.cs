using UnityEngine;

namespace Ekaterina
{
    public class MarsPlayer : MonoBehaviour
    {
        public bool IsShaded { get; private set; } = false;

        void Update()
        {
            // TODO make this use OnTriggerEnter/Exit instead of Update
            if (Input.GetKey(KeyCode.Space))
            {
                IsShaded = true;
            }
            else
            {
                IsShaded = false;
            }
        }
    }
}