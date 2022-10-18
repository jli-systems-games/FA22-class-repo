using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AishaLifelike
{
    public class HealthBarAisha : MonoBehaviour
    {
        public Image HealthBar;
        public float CurrentHealth;
        public float MaxHealth =100f;
        // PlayerMovementScript Player;

        public void Start()
        {
        HealthBar=GetComponent<Image>();
        //  Player=FindObjectOfType<PlayerMovementScript>();
        }
        private void Update()
        {

        //  CurrentHealth == Player.Health;
        //  HealthBar.fillAmount == CurrentHealth / MaxHealth;
        }
    }
}