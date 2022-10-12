using UnityEngine;

namespace MunroHoberman.StateMachine
{
    public class GuardChaseState : GuardBaseState
    {
        public override void EnterState(GuardStateManager guard)
        {
            guard._agent.speed = 5;
        }

        public override void UpdateState(GuardStateManager guard)
        {
           guard._agent.SetDestination(guard._player.position);
            if (Vector3.Distance(guard.transform.position,guard._player.position)>guard.sight)
            {
                guard.SwitchState(guard.patrolState);
            }
        }
    }
}