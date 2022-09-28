using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace HectorRodriguez
{
    public class TrashClicker : MonoBehaviour
    {


        public int plastic;
        public int metal;
        public int electornics;
        public TMP_Text text;
        public TMP_Text text1;
        public TMP_Text text2;

        public int ValueIncreaseMultiplier = 1;


        private bool Upgrade1, Upgrade2, Upgrade3, Upgrade4;
        public Button Button1, Button2, Button3, Button4;



        void Start()
        {
            Upgrade1 = false;
            Upgrade2 = false;
            Upgrade3 = false;
            Upgrade4 = false;
        }

        //Can access outside of the script
        public void IncreaseValue()
        {

            plastic = (plastic + ValueIncreaseMultiplier);

        }
        public void IncreaseValue1()
        {
            metal = (metal + ValueIncreaseMultiplier);
        }

        public void IncreaseValue2()
        {
            electornics = (electornics + ValueIncreaseMultiplier);
        }


        public void IncreaseMulitplier(int value)
        {
            if (value == 1)
            {
                if (Upgrade1 == false)
                {
                    if (plastic > 4)
                    {
                        ValueIncreaseMultiplier = ValueIncreaseMultiplier + 1;
                        plastic = plastic - 5;

                        Upgrade1 = true;

                    }
                }
            }
            if (value == 2)
            {
                if (Upgrade2 == false)
                {
                    if (plastic > 49 && metal == 0)
                    {
                        ValueIncreaseMultiplier = ValueIncreaseMultiplier + 2;
                        plastic = plastic - 50;
                        metal = metal + 10;

                        Upgrade2 = true;
                    }
                }

            }
            if (value == 3)
            {
                if (Upgrade3 == false)
                {
                    if (plastic > 199 && metal > 100)
                    {
                        ValueIncreaseMultiplier = ValueIncreaseMultiplier + 3;
                        plastic = plastic - 200;
                        metal = metal - 50;
                        electornics = electornics + 10;
                        Upgrade3 = true;
                    }
                }

            }
            if (value == 4)
            {
                if (Upgrade4 == false)
                {
                    if (plastic > 549)
                    {
                        ValueIncreaseMultiplier = ValueIncreaseMultiplier + 4;
                        plastic = plastic - 550;

                        Upgrade4 = true;
                    }
                }

            }
        }

        void Update()
        {
            text.text = plastic.ToString();
            text1.text = metal.ToString();

            if (Upgrade1 == false)
            {
                Button1.interactable = true;
            }
            else
            {
                Button1.interactable = false;
            }
            if (Upgrade2 == false)
            {
                Button2.interactable = true;

            }
            else

            {
                Button2.interactable = false;
            }
            if (Upgrade3 == false)
            {
                Button3.interactable = true;
            }
            else
            {
                Button3.interactable = false;
            }
            if (Upgrade4 == false)
            {
                Button4.interactable = true;
            }
            else
            {
                Button4.interactable = false;
            }
        }
    }
}