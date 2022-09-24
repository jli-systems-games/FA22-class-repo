using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace godzillabanana
{

    public class Unicode : MonoBehaviour
    {
        public Transform firstPos;
        public Transform recentPos;


        public string unicornType;
        public bool isClicked;
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
            poop += 1;
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
