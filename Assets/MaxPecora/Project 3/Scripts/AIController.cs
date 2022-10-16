using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace max
{


    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(NavMeshAgent))]

    public class AIController : MonoBehaviour
    {
        public NavMeshAgent agent;

        [Range(0, 100)] public float speed;
        [Range(1, 500)] public float walkRadius;

        public void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            if(agent != null)
            {
                agent.speed = speed;
                agent.SetDestination(RandomNavMeshLocation());
            }
        }

        public void Update()
        {
            if(agent != null && agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.SetDestination(RandomNavMeshLocation());
            }
        }


        public Vector3 RandomNavMeshLocation()
        {

            Vector3 finalPosition = Vector3.zero;
            Vector3 randomPosition = Random.insideUnitSphere * walkRadius;
            randomPosition += transform.position;

            if(NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, walkRadius, 1))
            {
                finalPosition = hit.position;
            }
            return finalPosition;
        }

    }
}
