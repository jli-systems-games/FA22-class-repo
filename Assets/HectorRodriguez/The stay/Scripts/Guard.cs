using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace HectorRodriguez.Pathfinding { 
public class Guard : MonoBehaviour
{
    private NavMeshAgent _agent;
    public Transform[] waypoints;
    private Transform _player;
    private int _targetIndex = 0;
    public float sight = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _agent = transform.GetComponent<NavMeshAgent>();
        _player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 3;
        if (Vector3.Distance(transform.position, _player.position) < sight
            && !Physics.Linecast(transform.position, _player.transform.position, layerMask))
        {
            _agent.SetDestination(_player.position);
        }
        if (!_agent.hasPath || _agent.velocity.sqrMagnitude == 0f)
        {
            GoToNextLocation();
        }
    }

    public void GoToNextLocation()
    {
        _agent.SetDestination(waypoints[_targetIndex].position);
        _targetIndex = (_targetIndex + 1) % waypoints.Length;
    }

}
}
