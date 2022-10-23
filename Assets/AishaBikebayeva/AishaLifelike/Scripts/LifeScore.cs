using TMPro;
using UnityEngine;

// using PlayerMovementScript;
namespace AishaBikebayeva.AishaLifelike.Scripts
{
    public class LifeScore : MonoBehaviour
    {
        public TMP_Text scoreText; 

        //public Sprite explosion;
        //private SpriteRenderer sr;

        //private variables have to be set in code
        public static float score;
    

        //Start is called at game start, sets the score to 0
        void Start()
        {
            score = 0;
        }

        // Update is called once per frame
        void Update()
        {
            // if (AishaLifelike.PlayerMovementScript.hitInfo.transform.tag=="Dummie") {
                scoreText.text = "Score: " + score; 
                //score += Time.deltaTime;                                         
                // score += 1;  
                // Destroy(GameObject.tag=="Dummie")                                                           
            // }                                                       
        }
    }
}