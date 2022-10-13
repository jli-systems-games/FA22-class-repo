using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

namespace Simon.Project3.Scripts
{
    public class LevelMorph : MonoBehaviour
    {

        public NavMeshSurface surface;
        void Start()
        {
            //UPDATE NAVMESH
            surface.BuildNavMesh();
        }

        void Update()
        {
        
        }
    }

}
