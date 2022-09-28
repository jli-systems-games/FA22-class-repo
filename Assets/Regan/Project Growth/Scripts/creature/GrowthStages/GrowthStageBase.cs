using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan
{

    public abstract class GrowthStageBase : ScriptableObject
    {
        [SerializeField, Range(0f, 1.1f)] private float _healHungerThreshold = 0.3f;
        [SerializeField] private int _nextStageThreshold = 200;
        [SerializeField] private GrowthStageBase _nextStage;
        [SerializeField] private Sprite _creatureSprite;

        public bool canFeed = true;

        protected CreatureManager _creatureManager;

        public virtual void StageStart(CreatureManager creatureManager)
        {
            _creatureManager = creatureManager;
            _creatureManager.ChangeSprite(_creatureSprite);
        }

        public virtual void Tick()
        {
            UpdateAge();
            UpdateHealth();
            UpdateHunger();
        }

        public virtual void UpdateHunger()
        {

            if (_creatureManager.hunger <= 0)
            {
                return;
            }

            _creatureManager.ChangeHunger(-1);
        }

        public virtual void UpdateHealth()
        {
            if (_creatureManager.hunger > _creatureManager.maxHunger * _healHungerThreshold)
            {
                _creatureManager.ChangeHealth(1);
                return;
            }

            if (_creatureManager.hunger > 0)
            {
                return;
            }

            _creatureManager.ChangeHealth(-1);

            if (_creatureManager.health > 0)
            {
                return;
            }

            _creatureManager.Die();
        }

        public virtual void UpdateAge()
        {
            _creatureManager.age++;

            if (_creatureManager.age > _nextStageThreshold)
            {
                _creatureManager.ChangeStage(_nextStage);
            }
        }


    }
}
