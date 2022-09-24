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
        
      
       void Update()
        {
            if (Input.mousePosition.x> 500)
            {
                Draw();
                //Debug.Log(Input.mousePosition);
            }
          
        }

        
        void Draw()
        {
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

        void createBrush()
        {

            GameObject brushInstance = Instantiate(brush);
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
            

        }

        void AddAPoint(Vector2 pointPos)
        {
            currentLineRenderer.positionCount++;
            int positionIndex = currentLineRenderer.positionCount - 1;
            currentLineRenderer.SetPosition(positionIndex, pointPos);
            //Debug.Log("positionIndex:" + positionIndex + ", pointpos:" + pointPos);

        }

        public void colorpick(SpriteRenderer selectedUnicorn)
        {
            uniColor = selectedUnicorn.color;
            Debug.Log(unicorn);
        }
    }

}