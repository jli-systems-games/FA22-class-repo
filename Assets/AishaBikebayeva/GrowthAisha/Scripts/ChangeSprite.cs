using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AishaBikebayeva.GrowthAisha.Scripts
{
    // [Serializable]
    public class ChangeSprite : MonoBehaviour
    {
        public Button Button;
        public TMP_Text text;
        public Button buttonPlay;
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
        if (clicks > 4)
        {
            text.enabled = true;
            buttonPlay.gameObject.SetActive(true);
            Button.gameObject.SetActive(false);
        }
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