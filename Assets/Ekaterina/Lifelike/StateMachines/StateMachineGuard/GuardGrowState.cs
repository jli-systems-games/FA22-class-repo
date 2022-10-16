using UnityEngine;

namespace MunroHoberman.StateMachine
{
    public class GuardGrowState : GuardBaseState
    {
        public override void EnterState(GuardStateManager guard)
        {
            guard.transform.localScale = new Vector3(10f,10f,10f);
        }

        public override void UpdateState(GuardStateManager guard)
        {
            if (Vector3.Distance(guard.transform.position,guard._player.position)>guard.sight*2)
            {
                guard.SwitchState(guard.patrolState);
            }

            float sizeSpeed = .001f;
            Vector3 size = guard.transform.localScale;
            guard.transform.localScale = new Vector3(size.x-sizeSpeed,size.y-sizeSpeed,size.z-sizeSpeed);
        }

        public override void ExitState(GuardStateManager guard)
        {
            
        }
    }
    
}