using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SharedAssets
{
    [RequireComponent(typeof(AudioSource))]
    public class FunScript : MonoBehaviour
    {

        [SerializeField] AudioClip clickClip;
        AudioSource audioData;

        // Start is called before the first frame update
        void Start()
        {
            audioData = GetComponent<AudioSource>();
            audioData.clip = clickClip;
        }

        public void Click()
        {
            audioData.Play();
        }
    }
}