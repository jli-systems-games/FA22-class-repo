using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganFinal
{
    [CreateAssetMenu(menuName = "ReganFinal/GrowthStages/AdultStage")]
    public class AdultStage : GrowthStageBase
    {
        public override void UpdateAge()
        {
            base.UpdateAge();
        }

        public override void UpdateHunger()
        {
            base.UpdateHunger();

            _creatureManager.ChangeHunger(-1);
        }
    }
}

