using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{
    public class ColliderDisabled : MonoBehaviour
    {
        public BoxCollider2D objectA;
        BoxCollider2D player;
        
        void OnCollisionEnter2D(Collision2D player)
        {

            if (player.gameObject.name == "Object B")
            {
                objectA.enabled = false;
                Debug.Log("Collision!");
                
            }
        }
    }
}


