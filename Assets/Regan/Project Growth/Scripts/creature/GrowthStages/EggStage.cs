using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggStage : GrowthStageBase
{
    public EggStage(CreatureManager creatureManager) : base(creatureManager)
    {
    }

    public override void Tick()
    {
        base.Tick();

    }

    public override void UpdateAge()
    {
        base.UpdateAge();

        if (_creatureManager.age > 20)
        {
            _creatureManager.ChangeStage(new BabyStage(_creatureManager));
        }
    }
}
