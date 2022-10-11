
using UnityEngine;
using UnityEngine.UI;
namespace mahedav {
    
    
    
    public class Colors : MonoBehaviour
    {

        public Image monsterColor;
        
       
        // Start is called before the first frame update
        void Start()
        {
            monsterColor = gameObject.GetComponent<Image>();
            
         monsterColor.color =
                new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
Debug.Log(monsterColor.color);
        }
        
        
        void Update()
        {
            gameObject.GetComponent<Image>().color =
                new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
            Debug.Log(monsterColor.color);
        }
        

        
    }
}
