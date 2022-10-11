using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EkaterinaFunButton
{
    public class ChangeShape : MonoBehaviour
    {
        public Button button;
    
        public Sprite OffSprite;
        public Sprite OnSprite;

        // Start is called before the first frame update
        void Start()
        {
            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(ChangeImage);
        }


        public void ChangeImage(){
            if (button.image.sprite == OnSprite)
                button.image.sprite = OffSprite;
            else {
                button.image.sprite = OnSprite;
            }
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}