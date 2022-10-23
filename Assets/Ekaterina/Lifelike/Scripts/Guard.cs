
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

namespace Ekaterina {
    public class Guard : MonoBehaviour
    {
        NavMeshAgent _agent;
        public Transform[] targetLocations;
        public Transform playerTarget;
        private int _targetIndex = 0;
        public float sight = 10f;


        public Transform lastActiveWayPoint; //to keep track of where we were going so we know to go back to it
        public Transform activeTargetLocation;// for debugging
        
        private bool _isChasing = false;
        int layerMask = 1 << 3;

        // Start is called before the first frame update
        void Start()
        {
            _agent = transform.GetComponent<NavMeshAgent>();
            activeTargetLocation = lastActiveWayPoint = targetLocations[0]; //set the default targets
        }

        // Update is called once per frame
        void Update()
        {
            //if the player is suddenly shaded
            if (playerTarget.GetComponent<MarsPlayer>().IsShaded &&
                activeTargetLocation != lastActiveWayPoint)
            {
                _agent.SetDestination(lastActiveWayPoint.position);
                activeTargetLocation = lastActiveWayPoint;
            }
            //if the player is still visible
            if (IsPlayerVisible())
            {
                lastActiveWayPoint = targetLocations[_targetIndex];
                _agent.SetDestination(playerTarget.position);
                activeTargetLocation = playerTarget;
            }
            else //if we're normally moving, this remains unchanged
            {
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
            
        }


        // Separate function because we will do this evaluation mutiple times
        bool IsPlayerVisible()
        {
            return Vector3.Distance(transform.position, playerTarget.position) < sight
                && !Physics.Linecast(transform.position, playerTarget.transform.position, layerMask) 
                && !playerTarget.GetComponent<MarsPlayer>().IsShaded;
            
        }

        public void GoToNextLocation()
        {
            _agent.SetDestination(targetLocations[_targetIndex].position);
            _targetIndex = (_targetIndex+ 1) % targetLocations.Length;
            
            activeTargetLocation = targetLocations[_targetIndex];
        }
        
    }
}