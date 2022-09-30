using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace godzillabanana
{
    public class Drawing : MonoBehaviour
    {
        public Camera mainCamera;
        public GameObject brush;
        LineRenderer currentLineRenderer;
        Vector3 lastpos;
        public SpriteRenderer unicorn;
        public Color uniColor;
        public Unicode currentUnicorn;
        public GameObject canvas;


        private void Start()
        {
            canvas = GameObject.Find("Canvas");
        }
        void Update()
        {
            if (Input.mousePosition.x> 500)
            {
                Draw();
                //Debug.Log(Input.mousePosition);
                if (currentUnicorn == null)
                {
                    currentUnicorn = FindObjectOfType(typeof(Unicode)) as Unicode;
                    colorpick(currentUnicorn);

                }
            }
          
        }

        
        void Draw()
        {
            if (currentUnicorn != null) { 
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                createBrush();
                currentLineRenderer.material.color = uniColor;

               
            }
           
            if (Input.GetKey(KeyCode.Mouse0))
            {
                

                Vector3 mousePos = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500.0f)); 
                if (mousePos != lastpos)
                {
                    //Debug.Log("aaa" + mousePos+" != "+lastpos);
                    AddAPoint(mousePos);
                    lastpos = mousePos;
                }
                //else Debug.Log("ooo" + mousePos + " == " + lastpos);

            }
            else
            {
                currentLineRenderer = null;
            }

            }
        }

        void createBrush()
        {

            GameObject brushInstance = Instantiate(brush);
           brushInstance.transform.SetParent(canvas.transform, false);
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
            

        }

        void AddAPoint(Vector3 pointPos)
        {
            currentLineRenderer.positionCount++;
            int positionIndex = currentLineRenderer.positionCount - 1;
            currentLineRenderer.SetPosition(positionIndex, pointPos);
            currentUnicorn.bleed();

            //Debug.Log("positionIndex:" + positionIndex + ", pointpos:" + pointPos);
            

        }


        public void colorpick(Unicode selectedUnicorn)
        {
            uniColor = selectedUnicorn.color;
            currentUnicorn = selectedUnicorn;
            // Debug.Log(unicorn);
        }



    }

}