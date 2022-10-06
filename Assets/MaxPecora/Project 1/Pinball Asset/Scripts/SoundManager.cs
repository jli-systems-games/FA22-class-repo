using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxArcade
{

    public class SoundManager : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audioSource = null;

        [SerializeField] private AudioClip gameOver = null;
        [SerializeField] private AudioClip bouncerHit = null;
        [SerializeField] private AudioClip diamondCollect = null;

        private void Start()
        {
            if (gameOver == null)
                Debug.Log("A GameOver sound is not assigned. You can assign this SoundManager -> SoundManager (script) -> Game Over");
            if (bouncerHit == null)
                Debug.Log("A BouncerHit sound is not assigned. You can assign this SoundManager -> SoundManager (script) -> Bouncer Hit");
            if (diamondCollect == null)
                Debug.Log("A DiamondCollect sound is not assigned. You can assign this SoundManager -> SoundManager (script) -> Diamond Collect");
        }

        public void GameOver()
        {
            if (gameOver != null)
                audioSource.PlayOneShot(gameOver);
        }

        public void BouncerHit()
        {
            if (bouncerHit != null)
                audioSource.PlayOneShot(bouncerHit);
        }

        public void DiamondCollect()
        {
            if (diamondCollect != null)
                audioSource.PlayOneShot(diamondCollect);
        }
    }
}
