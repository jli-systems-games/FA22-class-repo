using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Bananagodzilla{
    public class RogueExplosion: MonoBehaviour
    {



        public float fl;
        public GameObject[] limbs;
    // Start is called before the first frame update
    void Start()
    {
        fl = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explode()
    {
        foreach (var limb in limbs)
        {
            limb.GetComponent<Rigidbody2D>().velocity =
                new Vector2(Random.Range(-fl, fl), Random.Range(-fl, fl));
        }
    }
}
}
