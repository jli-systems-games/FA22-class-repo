using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EkaterinaFunButton
{
    public class BackgroundChange : MonoBehaviour
    {
        public Image image;
        // public Color newColor;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        public void Change()
        {
            Color newColor = new Color( Random.value, Random.value, Random.value);
            image.color = newColor;
        }
    }
}