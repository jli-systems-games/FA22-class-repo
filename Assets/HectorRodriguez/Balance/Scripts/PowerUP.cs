using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez {
public class PowerUP : MonoBehaviour
{

    void OnTriggerEnter (Collider other)
    {
        SimpleSampleCharacterControl player = other.transform.GetComponent<SimpleSampleCharacterControl>();


            if (other.gameObject.CompareTag("Player"))
            {
            player.SpeedUpEnabled();
            Destroy(this.gameObject);
            }
    }
}
}