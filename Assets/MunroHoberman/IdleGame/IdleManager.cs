using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MunroHoberman.IdleGame
{
    public class IdleManager : MonoBehaviour
    {
        public float growAmount = 0f;
        public TextMeshProUGUI amountText;

        public int planters = 0;
        public float planterPrice = 0;
        public float planterBasePrice = 10;
        public float planterPriceMultiplier = 1.1f;
        public float planterProduction = .1f;

        public TextMeshProUGUI buildText;

        // Start is called before the first frame update
        void Start()
        {
            planterPrice = planterBasePrice;
            amountText.text = "0";
            buildText.text = $"Buy Planter ${planterPrice}";
            InvokeRepeating("MainLoop", 0f, .1f);
        }

        void MainLoop()
        {
            growAmount += planters * planterProduction;
        }

        void Update()
        {
            amountText.text =growAmount.ToString("0");
        }
        
        public void IncreaseNumber()
        {
            growAmount += 1;
        }

        public void BuyPlanter()
        {
            if (growAmount >= planterPrice)
            {
                
                planters++;
                growAmount -= planterPrice;
                planterPrice = Mathf.Floor(planterBasePrice * Mathf.Pow(planterPriceMultiplier,planters));
                buildText.text = $"Buy Planter ${planterPrice}";
            }
        }
    }
}