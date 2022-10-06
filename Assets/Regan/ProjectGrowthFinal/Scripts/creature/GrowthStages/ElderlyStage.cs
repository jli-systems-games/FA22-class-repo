using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganFinal
{
    [CreateAssetMenu(menuName = "ReganFinal/GrowthStages/ElderlyStage")]
    public class ElderlyStage : GrowthStageBase
    {
        public override void UpdateAge()
        {
            base.UpdateAge();
        }

        public override void UpdateHunger()
        {
            base.UpdateHunger();

            _creatureManager.ChangeHunger(-2);
        }
    }
}
