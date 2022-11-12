using UnityEngine;

namespace Nickel.NickelBalanace.script
{
   
    public class EnemyManager : MonoBehaviour
    {

        public Enemy enemyType;

        public string enemyName;
        public int enemyHealth;
       
        public Sprite enemySprite;
        public void LoadInfo()
        {
            enemyName = enemyType.enemyName; 
        }
        // Start is called before the first frame update
        
    }

}
