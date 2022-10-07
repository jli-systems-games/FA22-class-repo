using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using UnityEngine;

namespace Bananagodzilla
{
    

public class RogueEnemy : MonoBehaviour
{
    
    public int rage;
    public int bones;
    public int sugar;
    
    
    public RogueLimb[] limbs;

    public RogueHero hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hero)
        {
            hero = FindObjectOfType(typeof(RogueHero)) as RogueHero; }
    }




    public void fetch()
    {
        
    }
    public void Attack()
    {
        hero.rage -= bones;
        hero.bones -= sugar;
        hero.sugar -= rage;
        if (rage < 0 && sugar < 0 && bones < 0)
        {
            Debug.Log("Enemy Dead");
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