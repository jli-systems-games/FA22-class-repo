using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DavidBalance1{

public class rotate : MonoBehaviour
{


    public Vector3 dir;
    public float speed=1f;

    
        
    void Update()
    {
        this.transform.Rotate(dir*speed);
    }
}
}