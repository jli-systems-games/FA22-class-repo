using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MunroHoberman.Pathfinding {
   public class FixedCamera : MonoBehaviour
   {
      public GameObject followObject;

      void Update()
      {
         transform.position = followObject.transform.position;
      }
   }
}