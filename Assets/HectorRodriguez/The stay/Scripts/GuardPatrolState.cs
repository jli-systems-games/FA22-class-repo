
using UnityEngine;

namespace HectorRodriguez.StateMachine
{

public class GuardPatrolState : GuardBaseState
{
        public override void EnterState(GuardStateManager guard)
    {
        guard._agent.speed = 2;
        guard._player = GameObject.FindWithTag("Player").transform;
    }

    public override void UpdateState(GuardStateManager guard)
    {
        if (!guard._agent.hasPath || guard._agent.velocity.sqrMagnitude == 0f)
        {
            guard._agent.SetDestination(guard.waypoints[guard._targetIndex].position);
            guard._targetIndex = (guard._targetIndex + 1) % guard.waypoints.Length;
        }

        int layerMask = 1 << 3;
        if (Vector3.Distance(guard.transform.position, guard._player.position) < guard.sight
            && !Physics.Linecast(guard.transform.position, guard._player.transform.position, layerMask))
        {
            guard.SwitchState(guard.chaseState);
        }
    }

    public override void ExitState(GuardStateManager guard)
    {

    }
}
}