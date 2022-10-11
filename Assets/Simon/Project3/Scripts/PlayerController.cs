using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

namespace Simon.Project3.Scripts
{
        
        public class PlayerController : MonoBehaviour
        {

            public Camera cam;

            public NavMeshAgent agent;

            public Vector3 RandomNavmeshLocation(float radius)
            {
                Vector3 randomDirection = Random.insideUnitSphere * radius;
                randomDirection += transform.position;
                NavMeshHit hit;
                Vector3 finalPosition = Vector3.zero;
                if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
                {
                    finalPosition = hit.position;
                }

                return finalPosition;
            }
            
            private float nextActionTime = 0.0f;
            public float period = .01f;

        
            void Update()
            {
                if (Input.GetMouseButton(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        //move our agent to ray
                        agent.SetDestination(hit.point);
                    }
                }
                else
                {
                    if (Time.time > nextActionTime)
                    {
                        nextActionTime = Time.time + period;
                        agent.SetDestination(RandomNavmeshLocation(5f));
                        Debug.Log("new mark found");
                    }
                }
            }
        }

}