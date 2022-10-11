
using UnityEngine;
using UnityEngine.UI;
namespace mahedav
{
    public Image monsterSprite;
    public class Colors : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            monsterSprite = GameObject.GetComponent<Image>().color =
                new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
Debug.Log(color);
        }

        
    }
}