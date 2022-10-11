
using UnityEngine;
using UnityEngine.UI;
namespace mahedav {
    
    
    
    public class Colors : MonoBehaviour
    {

        public Image monsterColor;
        
       
        // Start is called before the first frame update
        void Start()
        {
            
        }
        
        
        void Update()
        {
            gameObject.GetComponent<Image>().color =
                new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
            Debug.Log(monsterColor.color);
        }



        public void colorChange()
        {
            
        }
        
    }
}
