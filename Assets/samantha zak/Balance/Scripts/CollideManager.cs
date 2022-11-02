using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SamBalance{
public class CollideManager : MonoBehaviour
{
   
    public GameObject theTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == theTrigger)
        {
            
        }

    }
    
}
}
