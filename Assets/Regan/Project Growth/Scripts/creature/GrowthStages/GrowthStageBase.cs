using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthStageBase
{
    private float _healHungerThreshold = 0.3f;

    protected readonly CreatureManager _creatureManager;
    public float stageStartTime;

    public GrowthStageBase(CreatureManager creatureManager)
    {
        _creatureManager = creatureManager;
    }

    public virtual void StageStart()
    {

    }

    public virtual void Tick()
    {
        UpdateAge();
        UpdateHealth();
        UpdateHunger();
        
    }

    public virtual void UpdateHunger()
    {

        if (_creatureManager.hunger <= 0) { return; }

        ChangeHunger(-1);
    }

    public virtual void UpdateHealth()
    {
        if (_creatureManager.hunger > _creatureManager.maxHunger * _healHungerThreshold )
        {
            ChangeHealth(1);
            return;
        }

        if (_creatureManager.hunger > 0) { return; }

        ChangeHealth(-1);

        if (_creatureManager.health > 0) { return; }

        _creatureManager.ChangeStage(new DeadStage(_creatureManager));
    }

    public virtual void UpdateAge()
    {
        _creatureManager.age++;
    }

    protected void ChangeHealth(int amount)
    {
        _creatureManager.health = Mathf.Clamp(_creatureManager.health + amount, 0, _creatureManager.maxHealth);
    }

    protected void ChangeHunger(int amount)
    {
        _creatureManager.hunger = Mathf.Clamp(_creatureManager.hunger + amount, 0, _creatureManager.maxHunger);
    }
}
