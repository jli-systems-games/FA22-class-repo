using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganLifeLike
{
    public class CharacterSounds : MonoBehaviour
    {
        [SerializeField]
        AudioSource _footstepAudio;

        public void OnFootStep()
        {
            _footstepAudio.Play();
        }
    }
}