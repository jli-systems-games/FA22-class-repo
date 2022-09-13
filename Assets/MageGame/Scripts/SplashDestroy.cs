using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace maiproject{
public class SplashDestroy : MonoBehaviour
{
public float deathTime;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        deathTime -= Time.deltaTime;
if (deathTime <= 0){
 Destroy(gameObject);

}

    }
}
}