using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez
{
    public class SecretDoor : MonoBehaviour
    {
        [SerializeField] private Animator secretDoor;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                secretDoor.SetBool("SecretDoorslide", true);
        }

     
    }
}