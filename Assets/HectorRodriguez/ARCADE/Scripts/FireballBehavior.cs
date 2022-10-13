using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hector
{
    [RequireComponent(typeof(Fireball))]
    public class FireballBehavior : MonoBehaviour
    {

        public Fireball fireball { get; private set; }
        public float duration;

        private void Awake()
        {
            fireball = GetComponent<Fireball>();
        }

        public void Enable()
        {
            Enable(duration);
        }

        public virtual void Enable(float duration)
        {
            enabled = true;

            CancelInvoke();
            Invoke(nameof(Disable), duration);
        }

        public virtual void Disable()
        {
            enabled = false;

            CancelInvoke();
        }

    }

}