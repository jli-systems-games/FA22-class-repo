using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike {
    public class ObjectMover : MonoBehaviour
    {
        private bool isDragging;

        public void OnMouseDown()
        {
            isDragging = true;
        }

        public void OnMouseUp()
        {
            isDragging = false;
        }

        void Update()
        {
            //Debug.Log(isDragging);
            if (isDragging)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                
                transform.Translate(mousePosition);
            }
        }


    }

}
