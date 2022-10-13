using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Bananagodzilla{
public class BattleButton : MonoBehaviour
{
    public RogueEnemy enemy;

    public RogueHero hero;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy = FindObjectOfType (typeof (RogueEnemy)) as RogueEnemy;
        hero = FindObjectOfType (typeof (RogueHero)) as RogueHero;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            enemy = FindObjectOfType (typeof (RogueEnemy)) as RogueEnemy; 
        }
    }

    public void Battle()
    {
        enemy.Attack();
        hero.Attack();
    }

    public void Refresh()
    {
        
    }
}
}