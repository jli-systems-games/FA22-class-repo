using UnityEngine;

namespace samantha_zak.Balance.Scripts{
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
