using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EkaterinaFunButton
{
    public class ButtonTense : MonoBehaviour
    {
        public Button button;
        
        void Start()
        {
            GetComponent<Button>();
        }
        
        public void ButtonTensity()
        {
            float t = (float)1 / 2;
        
            float buttonScale = Mathf.Lerp(1f, 10f, t);

            button.transform.localScale = new Vector3(buttonScale, buttonScale, buttonScale);


        }

        public void ButtonRevert()
        {

            button.transform.localScale = new Vector3(1, 1, 1);

        }

        void Update()
        {
        
        }
    }

}
