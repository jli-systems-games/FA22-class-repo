using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mariana
{
public class CameraFollow : MonoBehaviour
{
        public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3(target.position.x, target.position.y, -10);
    }
}
}
