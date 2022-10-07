using System.Collections;
using UnityEngine;

using TMPro;
using UnityEngine.UI;

namespace ReganFinal
{
    
    public class CreatureManager : MonoBehaviour
    {


        public GrowthStageBase currentStage;
        [SerializeField]
        private float _tickTime = 5;

        //creature stats
        public int age = 0;

        public int health = 180;
        public int maxHealth = 180;

        public int hunger = 3600;
        public int maxHunger = 3600;

        public int energy = 100;
        public int maxEnergy = 100;

        public bool lights = true;

        //dependencies
        [SerializeField]
        private TextMeshProUGUI _debugCreatureStateText;
        [SerializeField]
        private TextMeshProUGUI _debugHungerText;
        [SerializeField]
        private RectTransform _hungerBar;
        [SerializeField]
        private RectTransform _energyBar;
        [SerializeField]
        private Image _imageRenderer;
        [SerializeField]
        private Image _darkImageRenderer;
        [SerializeField]
        private GrowthStageBase _deadStage;

        //runtime
        private Coroutine _mainTickRoutine;

        private void Start()
        {


            ChangeStage(currentStage);
            StartMain();

        }

        private void StartMain()
        {
            _mainTickRoutine = StartCoroutine(MainTick(_tickTime));
        }

        public void ChangeStage(GrowthStageBase growthStage)
        {
            currentStage = growthStage;
            growthStage.StageStart(this);
            _debugCreatureStateText.text = (age / 20).ToString();
        }

        public void ChangeSprite(Sprite newSprite)
        {
            _imageRenderer.sprite = newSprite;
        }

        public void Feed(int amount)
        {
            if (!currentStage.canFeed) { return; }

            if (!lights) { return; }
            ChangeHunger(amount);
            RefreshUI();
        }

        public void ToggleLights()
        {
            lights = !lights;

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

        public void ChangeEnergy(int amount)
        {
            energy = Mathf.Clamp(energy + amount, 0, maxEnergy);
        }

        private void OnSaveTimeReceived(string date)
        {
            Debug.Log(date);
            PlayerPrefs.SetString("date", date);
        }

        private void Tick()
        {
            currentStage.Tick();
            RefreshUI();
        }

        private void RefreshUI()
        {

            _darkImageRenderer.enabled = !lights;
            _hungerBar.sizeDelta = new Vector2(hunger * 2, 16);
            _energyBar.sizeDelta = new Vector2(energy * 2, 16);
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

