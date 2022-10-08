
using UnityEngine;

namespace Bananagodzilla
{
    

public class RogueEnemy : MonoBehaviour
{
    
    public int rage;
    public int bones;
    public int sugar;
    public int number;
    public int[] rages;
    public int[] boness;
    public int[] carbs;
    public RogueLimb[] limbs;
    public RogueHero hero;

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
        
        
        
        
    }




    
    public void Attack()
    {
        hero.rage -= bones;
        hero.bones -= sugar;
        hero.sugar -= rage;
        if (rage <= 0 && sugar <= 0 && bones <= 0)
        {
            Die();
        }
    }
    
    
    

    
  


    void Die()
    {
        number++;
        rage = rages[number];
        bones = boness[number];
        sugar = carbs[number];
    }
}
}