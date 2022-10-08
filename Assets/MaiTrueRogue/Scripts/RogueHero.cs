using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Bananagodzilla{
public class RogueHero : MonoBehaviour
{
    public int rage;
    public int bones;
    public int sugar;
    public int health;
    public RogueEnemy enemy;
    public RogueLimb[] limbs;

    public TMP_Text[] texts;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        
        texts[0].SetText("Sugar: "+sugar.ToString());
        texts[1].SetText("Rage: "+rage.ToString());
        texts[2].SetText("Bones: "+bones.ToString());

        if (!enemy)
        {
            enemy = FindObjectOfType(typeof(RogueEnemy)) as RogueEnemy;
        }
       // Debug.Log(bones);
        
       
        
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
        Debug.Log("entered");
        if (col.GetComponent<RogueLimb>())
        {
           
            rage += col.GetComponent<RogueLimb>().rage;
            bones += col.GetComponent<RogueLimb>().bones;
            sugar += col.GetComponent<RogueLimb>().sugar;
            Debug.Log("triggered");
        }
        
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exited");
        if (col.GetComponent<RogueLimb>())
        {
            rage -= col.GetComponent<RogueLimb>().rage;
            bones -= col.GetComponent<RogueLimb>().bones;
            sugar -= col.GetComponent<RogueLimb>().sugar;
            Debug.Log("fjek");
        }
        
    }
}
}