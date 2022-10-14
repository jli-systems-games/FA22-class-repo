
using UnityEngine;
using TMPro;

namespace Bananagodzilla
{
    

public class RogueEnemy : MonoBehaviour
{
    public TMP_Text[] texts;
    public int rage;
    public int bones;
    public int sugar;
    public int number;
    public int[] rages;
    public int[] boness;
    public int[] carbs;
    
    public RogueHero hero;
    public GameObject[] enemies;
   

    public BodyManager bodyManager;
   // public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        rage = rages[number];
        bones = boness[number];
        sugar = carbs[number];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hero)
        {
            hero = FindObjectOfType(typeof(RogueHero)) as RogueHero; }

        if (!bodyManager)
        {
            bodyManager = FindObjectOfType(typeof (BodyManager)) as BodyManager;
        }
        
        texts[0].SetText("Sugar: "+sugar.ToString());
        texts[1].SetText("Rage: "+rage.ToString());
        texts[2].SetText("Bones: "+bones.ToString());
        
        
    }




    
    public void Attack()
    {
        if (bones >0){hero.rage -= bones;}
        if (sugar >0){hero.bones -= sugar;}
        if (rage>0){hero.sugar -= rage;}
        
        if (rage <= 0 && sugar <= 0 && bones <= 0)
        {
            Die();
        }
    }
    
    
    

    
  


    private void Die()
    {
        //enemies[number].SetActive(false);
        enemies[number].GetComponent<RogueExplosion>().Explode();
        hero.limbReset();
        hero.health = hero.health + 10;
        number++;
        enemies[number].SetActive(true);
        rage = rages[number];
        bones = boness[number];
        sugar = carbs[number];
        bodyManager.getBody();
        bodyManager.bodyCount++;
        Debug.Log(bodyManager.bodyCount);

    }
}
}