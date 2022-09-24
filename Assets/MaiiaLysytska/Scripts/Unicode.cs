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
        public Transform firstPos;
        public Transform recentPos;
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
        }

        // Update is called once per frame
        void Update()
        {
            if(Timer<= 0) { 
            poop += poopValue;
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
            gameObject.transform.position = Input.mousePosition;
            recentPos.position = Input.mousePosition;
        }
        private void OnMouseDrag()
        {
            gameObject.transform.position = Input.mousePosition;
            recentPos.position = Input.mousePosition;
        }
        private void OnMouseUp()
        {
            gameObject.transform.position = recentPos.position;

        }
    }
}
