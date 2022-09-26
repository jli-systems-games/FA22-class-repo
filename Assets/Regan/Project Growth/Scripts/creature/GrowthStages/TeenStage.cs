using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeenStage : GrowthStageBase
{
    public TeenStage(CreatureManager creatureManager) : base(creatureManager)
    {
    }

    public override void UpdateAge()
    {
        base.UpdateAge();

        if (_creatureManager.age > 100)
        {
            _creatureManager.ChangeStage(new AdultStage(_creatureManager));
        }
    }
}
