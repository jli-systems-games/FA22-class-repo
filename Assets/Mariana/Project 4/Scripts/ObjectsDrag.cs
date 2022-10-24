using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
    public class ObjectsDrag : MonoBehaviour
    {
        //private float startPosX;
        //private float startPosY;
        private bool dragging = false;
        private Vector3 offset;

        void Update()
        {
           /* if (isBeingHeld == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
            }*/
           if (dragging)
           {
               transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
           }
        }

        private void onMouseDown()
        {
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dragging = true;
            /*if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                isBeingHeld = true;
            }*/


        }

        private void onMouseUp()
        {
            dragging = false;
            //isBeingHeld = false;

        }
    }
}
