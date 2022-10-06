using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Mariana

{
    public class PageTurn : MonoBehaviour
    {
       // public int index;
        public GameObject Panel ;
        
        // Start is called before the first frame update
        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
               
                Panel.SetActive(true);
               // index++;
                

            }

        }
      
    }
}