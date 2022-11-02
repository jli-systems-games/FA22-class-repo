using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Regan.Balance
{
    public class CollectionManager : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _scoreText;
        [SerializeField]
        private AudioSource _collectAudio; 
        [SerializeField]
        private AudioSource _deathAudio;
        [SerializeField]
        private AudioSource _winAudio;

        private int _score = 0;

        private void OnEnable()
        {
            Ball.OnCollect += OnCollect;
            Ball.OnDeath += OnDeath;
            Ball.OnWin += OnWin;
        }

        private void OnDisable()
        {
            Ball.OnCollect -= OnCollect;
            Ball.OnDeath -= OnDeath;
            Ball.OnWin -= OnWin;
        }

        private void OnCollect(int amount)
        {
            _score += amount;
            _collectAudio.Play();
            UpdateScore();
        }

        private void UpdateScore()
        {
            _scoreText.text = $"score: {_score}";
        }

        private void OnDeath()
        {
            _deathAudio.Play();
            UpdateScore();
        }

        private void OnWin()
        {
            _winAudio.Play();
        }
    }
}

