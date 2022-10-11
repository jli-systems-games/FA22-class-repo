using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace EkaterinaFunButton
{
    
    public class ButtonShaker : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        public Animator anim;
        
        public bool buttonPressed;
 
        public void OnPointerDown(PointerEventData eventData){
            buttonPressed = true;
        }
 
        public void OnPointerUp(PointerEventData eventData){
            buttonPressed = false;
        }
        
        void Start()
        {
            GetComponent<Animator>();
        }

        void Update()
        {
            if (buttonPressed = true)
            {
                anim.Play("");
            }
        }
    }

    
}
