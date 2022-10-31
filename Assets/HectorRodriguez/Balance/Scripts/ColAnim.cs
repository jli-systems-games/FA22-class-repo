using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColAnim : MonoBehaviour
{
        public string anima;

    private Trap1 _platform;

    private void Start()
    {
        _platform = GameObject.FindGameObjectWithTag("Platform").GetComponent<Trap1>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _platform.ChangeAnimationState(anima);
        }
    }

}

