
using UnityEngine;
using UnityEngine.UI;
namespace mahedav {
    public class Colors : MonoBehaviour
    {



        public float colorRange;
        public Transform colorPoint;
        public LayerMask monsterLayer;
       
       
        // Start is called before the first frame update
     
        
      


        public void colorChange()
        {
            
            Collider2D[] monsters = Physics2D.OverlapCircleAll(colorPoint.position, colorRange, monsterLayer);
            Debug.Log("hit"+ monsters[0]);
            foreach(Collider2D monster in monsters)
            {
               
               monster.GetComponent<Image>().color =  new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
            }
        }
        
    }
}
