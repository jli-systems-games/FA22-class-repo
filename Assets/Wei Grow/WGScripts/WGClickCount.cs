using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




namespace Bloom
{
    [ExecuteInEditMode()]
    public class WGClickCount : MonoBehaviour
    {



        public int maximum;
        public int current = 10;
        public Image mask;
        public int minimum;
        public GameObject Ceffect1;
        public GameObject Ceffect2;
        public GameObject Ceffect3;
        public GameObject Ceffect4;
        public GameObject Ceffect5;
        public GameObject Ceffect6;
        public GameObject Itself;
        public GameObject Cross1;
        public GameObject Photo1;
     


        void Start()
        {
          

        }

        void Update()
        {

            GetCurrentFill(); 

            if (Input.GetMouseButtonDown(0))
            {
                current = (current + 400);
            }

           if ( current> 5)
         {
                current = (current - 1);
         }


           if (current > 4000)
            {
                Ceffect1.SetActive(true);
            }


            if (current > 5000)
            {
                Ceffect2.SetActive(true);
            }

            if (current > 6000)
            {
                Ceffect3.SetActive(true);
            }

            if (current > 7000)
            {
                Ceffect4.SetActive(true);
            }

            if (current > 8000)
            {
                Ceffect5.SetActive(true);
                
            }

            if (current > 9000)
            {
                Ceffect6.SetActive(true);
              


            }

          
            

            if (current > 11000)
            {
                Photo1.SetActive(true);
                Destroy(Cross1);
                Destroy(Ceffect1);
                Destroy(Ceffect2);
                Destroy(Ceffect3);
                Destroy(Ceffect6);
                Destroy(Ceffect4);
                Destroy(Ceffect5);
                Destroy(Itself);

            }
        }

        void GetCurrentFill()

        {


            float currentOffset = current - minimum;
            float maximumOffset = maximum - minimum;
            float fillAmount = currentOffset / maximumOffset ;
            mask.fillAmount = fillAmount;

        }

     
    }

   

}