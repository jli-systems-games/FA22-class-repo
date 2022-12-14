using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganLifeLike
{
    public class WeaponSound : MonoBehaviour
    {
        [SerializeField]
        AudioSource _weaponAudio;

        public void OnAttack()
        {
            _weaponAudio.Play();
        }
    }
}