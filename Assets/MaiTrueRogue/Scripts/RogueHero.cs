
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