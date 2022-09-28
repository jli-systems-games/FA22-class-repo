using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AishaGrowth
{
    // [Serializable]
    public class ChangeSprite : MonoBehaviour
    {
        public Button Button;
        public Sprite image;
        int clicks = 0;
        public List<Sprite> sprites;
        // Start is called before the first frame update
        void Start()
        {
            
        }
        private void OnButtonClick()
        {
        GetComponent<SpriteRenderer>().sprite = sprites[clicks];
        clicks++;
        // clicks = clicks % sprites.length; 
        //to ensure the clicks dont go over your sprite count
        }

        void Awake()
        {
            Button.onClick.AddListener(OnButtonClick);
            Debug.Log("Ended");
            // image.enabled = !image.enabled;
            // Button.SetActive(false); 
        }
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}