using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan {

public class DestroyTimeout : MonoBehaviour
{
    [SerializeField] float lifeTime = 2;

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime > 0) { return; }
        Destroy(gameObject);
    }
}
}
