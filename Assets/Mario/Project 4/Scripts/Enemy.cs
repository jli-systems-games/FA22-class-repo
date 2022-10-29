using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioBalance
{
    public enum EnemyTypes
    {
        Melee,
        Magic,
        Archer
    }

    [CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy 2")]

    public class Enemy : ScriptableObject
    {
        public Enemy enemyType;

        public string enemyName;
        public int enemyHealth;
        public EnemyTypes enemy;

        public Sprite enemySprite;
    }
}