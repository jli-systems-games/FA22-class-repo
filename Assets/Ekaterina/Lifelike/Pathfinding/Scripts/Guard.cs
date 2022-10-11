
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace MunroHoberman.Pathfinding {
    public class Guard : MonoBehaviour
    {
        NavMeshAgent _agent;
        public Transform[] targetLocations;
        public Transform playerTarget;
        private int _targetIndex = 0;
        public float sight = 10f;
        
        // Start is called before the first frame update
        void Start()
        {
            _agent = transform.GetComponent<NavMeshAgent>();
        }
    
        // Update is called once per frame
        void Update()
        {
            int layerMask = 1 << 3;
            if (Vector3.Distance(transform.position,playerTarget.position)<sight 
                && !Physics.Linecast (transform.position, playerTarget.transform.position,layerMask)) {
                _agent.SetDestination(playerTarget.position);
            }
            if (!_agent.pathPending)
            { 
                if (_agent.remainingDistance <= _agent.stoppingDistance)
                {
                    if (!_agent.hasPath || _agent.velocity.sqrMagnitude == 0f)
                    {
                        GoToNextLocation();
                    }
                }
            }
        }

        public void GoToNextLocation()
        {
            _agent.SetDestination(targetLocations[_targetIndex].position);
            _targetIndex = (_targetIndex+ 1) % targetLocations.Length;
        }
        
    }
}