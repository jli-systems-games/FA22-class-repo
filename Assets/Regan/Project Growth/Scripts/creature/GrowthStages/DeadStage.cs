using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan
{

    [CreateAssetMenu(menuName = "Regan/GrowthStages/DeadStage")]
    public class DeadStage : GrowthStageBase
    {
        public override void Tick()
        {

        }

        public override void StageStart(CreatureManager creatureManager)
        {
            base.StageStart(creatureManager);
        }

        public override void UpdateAge()
        {

        }
    }
}
