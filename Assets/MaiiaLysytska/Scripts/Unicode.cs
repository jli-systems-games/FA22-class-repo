using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
namespace godzillabanana
{

    public class Unicode : MonoBehaviour
    {
        public Camera mainCamera;
        //public Vector3 mousePos;
        public Drawing drawing;
        public Transform recentPos;
        public Transform ponyPos;
        public TMP_Text text;
        public int poopValue;
        public string unicornType;
        private float Timer = 5;
        public float TimerValue;
        public int poop;
        public Color color;
        
        // Start is called before the first frame update
        void Start()
        {
           
            color = gameObject.GetComponent<SpriteRenderer>().color;
            //rectTransform = GetComponent<RectTransform>();
            // canvasgroup = GetComponent<CanvasGroup>();
            ponyPos = GetComponent<Transform>();

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            poop += poopValue;
            if (Timer<= 0) { 
           
                Timer = TimerValue;
               
            }

            Timer -= Time.deltaTime;
            text.text = poop.ToString();
            // Debug.Log(poop + "resource produced");

        }

        public void bleed()
        {
            poop -= 5;
        }

        private void OnMouseDown()
        {
            Debug.Log("isClicked");
           // ponyPos.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            drawing.colorpick(this);


            //recentPos.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
        private void OnMouseDrag()
        {
            Debug.Log("isDragged");





           ponyPos.position = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500.0f));  


        }

    }
}
