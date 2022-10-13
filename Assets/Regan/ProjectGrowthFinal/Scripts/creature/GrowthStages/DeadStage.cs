using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganFinal
{
    [CreateAssetMenu(menuName = "ReganFinal/GrowthStages/DeadStage")]
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