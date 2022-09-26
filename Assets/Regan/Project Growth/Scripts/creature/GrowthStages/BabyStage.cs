using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyStage : GrowthStageBase
{
    public BabyStage(CreatureManager creatureManager) : base(creatureManager)
    {
    }

    public override void UpdateAge()
    {
        base.UpdateAge();

        if (_creatureManager.age > 50)
        {
            _creatureManager.ChangeStage(new TeenStage(_creatureManager));
        }
    }
}
