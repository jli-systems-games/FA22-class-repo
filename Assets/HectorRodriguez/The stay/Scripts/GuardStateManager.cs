
using UnityEngine;

namespace HectorRodriguez.StateMachine { 
public class GuardStateManager : MonoBehaviour
{
    public int _targetIndex = 0;
    public Transform _player;
    public Transform[] waypoints;
    public UnityEngine.AI.NavMeshAgent _agent;
    public float sight = 10f;


    public GuardBaseState currentState;
    public GuardPatrolState patrolState = new GuardPatrolState();
    public GuardChaseState chaseState = new GuardChaseState();
    

    void Start()
    {
        _agent = transform.GetComponent<UnityEngine.AI.NavMeshAgent>();
        SwitchState(patrolState);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(GuardBaseState state)
    {
        // currentState.ExitState(this);
        currentState = state;
        state.EnterState(this);
    }
}
}
