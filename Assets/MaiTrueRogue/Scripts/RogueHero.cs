using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla{
public class RogueHero : MonoBehaviour
{
    public int rage;
    public int bones;
    public int sugar;
    public int health;
    public RogueEnemy enemy;
    public RogueLimb[] limbs;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!enemy)
        {
            enemy = FindObjectOfType(typeof(RogueEnemy)) as RogueEnemy;
        }
        
        
    }


    public void Attack()
    {
        enemy.rage -= bones;
        enemy.bones -= sugar;
        enemy.sugar -= rage;
        if (rage < 0 && sugar < 0 && bones < 0)
        {
            Debug.Log("Hero Dead");
        }
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<RogueLimb>())
        {
            rage += col.GetComponent<RogueLimb>().rage;
            bones += col.GetComponent<RogueLimb>().bones;
            sugar += col.GetComponent<RogueLimb>().sugar;
        }
    }

    public void equip()
    {
        foreach (RogueLimb limb in limbs)
        {
            rage += limb.rage;
            bones += limb.bones;
            sugar += limb.sugar;

        }
    }
}
}