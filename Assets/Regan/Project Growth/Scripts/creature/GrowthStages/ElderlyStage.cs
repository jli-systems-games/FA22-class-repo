using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElderlyStage : GrowthStageBase
{
    public ElderlyStage(CreatureManager creatureManager) : base(creatureManager)
    {
    }

    public override void UpdateAge()
    {
        base.UpdateAge();

        if (_creatureManager.age > 200)
        {
            _creatureManager.ChangeStage(new (_creatureManager));
        }
    }
}
