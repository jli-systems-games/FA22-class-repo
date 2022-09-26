using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultStage : GrowthStageBase
{
    public AdultStage(CreatureManager creatureManager) : base(creatureManager)
    {
    }

    public override void UpdateAge()
    {
        base.UpdateAge();

        if (_creatureManager.age > 150)
        {
            _creatureManager.ChangeStage(new (_creatureManager));
        }
    }
}
