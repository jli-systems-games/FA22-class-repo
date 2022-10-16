
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace MunroHoberman.Pathfinding
{
    public class Player : MonoBehaviour
    {
        private NavMeshAgent _agent;
        // Start is called before the first frame update
        void Start()
        {
            _agent = transform.GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out var hitInfo, 100f))
                {
                    _agent.SetDestination(hitInfo.point);
                }
            }
        }
    }
}