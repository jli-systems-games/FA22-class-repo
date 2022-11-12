using UnityEngine;

namespace Nickel.NickelBalanace.script
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


