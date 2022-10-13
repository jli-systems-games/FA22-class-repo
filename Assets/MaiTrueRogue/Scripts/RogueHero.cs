
using UnityEngine;
using TMPro;
namespace Bananagodzilla{
public class RogueHero : MonoBehaviour
{
    public GameObject deathScreen;
    public int rage;
    public int bones;
    public int sugar;
    public float health = 100;
    public RogueEnemy enemy;
    

    public TMP_Text[] texts;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        
        texts[0].SetText("Sugar: "+sugar.ToString());
        texts[1].SetText("Rage: "+rage.ToString());
        texts[2].SetText("Bones: "+bones.ToString());
        texts[3].SetText("HP: "+health.ToString());
        if (!enemy)
        {
            enemy = FindObjectOfType(typeof(RogueEnemy)) as RogueEnemy;
        }

        if (health <= 0)
        {
            deathScreen.SetActive(true);
        }
        
    }


    public void Attack()
    { 
        if (bones > 0){enemy.rage -= bones;}
        if (sugar>0){enemy.bones -= sugar;}
        if (rage >0){enemy.sugar -= rage;}
        
        if (rage < 0 || sugar < 0 || bones < 0)
        {
            health-= 10;
        }
    }




    public void limbCheck(RogueLimb limb)
    {
        rage += limb.rage;
        sugar += limb.sugar;
        bones += limb.bones;
    }

    public void limbRemove(RogueLimb limb)
    {
        rage -= limb.rage;
        sugar -= limb.sugar;
        bones -= limb.bones;
    }

    public void limbReset()
    {
        rage = 0;
        sugar = 0;
        bones = 0;

    }
    
}
}