using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

namespace Regan
{

    [RequireComponent(typeof(NetTime))]
    public class CreatureManager : MonoBehaviour
    {
        public GrowthStageBase currentStage;
        [SerializeField] private float _tickTime = 5;

        //creature stats
        public int age = 0;

        public int health = 180;
        public int maxHealth = 180;

        public int hunger = 3600;
        public int maxHunger = 3600;

        //dependencies
        private NetTime netTime;
        [SerializeField] private TextMeshProUGUI _debugCreatureStateText;
        [SerializeField] private TextMeshProUGUI _debugHungerText;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private GrowthStageBase _deadStage;

        //runtime
        private Coroutine _mainTickRoutine;

        private void Start()
        {
            netTime = GetComponent<NetTime>();
            netTime.getInternetTime(OnTimeReceived);

            ChangeStage(currentStage);
            _mainTickRoutine = StartCoroutine(MainTick(_tickTime));
        }

        public void ChangeStage(GrowthStageBase growthStage)
        {
            currentStage = growthStage;
            growthStage.StageStart(this);
            _debugCreatureStateText.text = currentStage.GetType().ToString().Split("Stage")[0];
        }

        public void ChangeSprite(Sprite newSprite)
        {
            _spriteRenderer.sprite = newSprite;
        }

        public void Feed(int amount)
        {
            if (!currentStage.canFeed)
            {
                return;
            }

            ChangeHunger(amount);
            RefreshUI();
        }

        public void Die()
        {
            ChangeStage(_deadStage);
        }

        public void ChangeHealth(int amount)
        {
            health = Mathf.Clamp(health + amount, 0, maxHealth);
        }

        public void ChangeHunger(int amount)
        {
            hunger = Mathf.Clamp(hunger + amount, 0, maxHunger);
        }

        private void OnTimeReceived(string time)
        {
            Debug.Log(time);
        }

        private void Tick()
        {
            currentStage.Tick();
            RefreshUI();
        }

        private void RefreshUI()
        {
            _debugHungerText.text = $"Hunger: {hunger}";
        }

        private IEnumerator MainTick(float deltaTime)
        {
            YieldInstruction waitTimeInstruction = new WaitForSeconds(deltaTime);

            while (true)
            {
                Tick();
                yield return waitTimeInstruction;
            }
        }


    }
}

