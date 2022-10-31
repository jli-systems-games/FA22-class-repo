using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickel
{
    public enum EnemyTypes
    {
        Melee,
        Magic,
        Archer
    }
    [CreateAssetMenu(fileName ="New Enemy",menuName ="Enemy 2")]
    public class Enemy : ScriptableObject
    {

        public string enemyName;
        public int enemyHealth;
        // Start is called before the first frame update
        public Sprite enemySprite;
        public EnemyTypes enemyType;
    }
}


