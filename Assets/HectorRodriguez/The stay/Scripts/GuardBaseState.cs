
using UnityEngine.AI;

namespace HectorRodriguez.StateMachine { 
public class GuardBaseState
{
    public virtual void EnterState(GuardStateManager guard) { }

    public virtual void UpdateState(GuardStateManager guard) { }

    public virtual void ExitState(GuardStateManager guard) { }
}
}

