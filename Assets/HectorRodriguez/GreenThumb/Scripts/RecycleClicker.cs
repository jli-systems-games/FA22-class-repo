using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecycleClicker : MonoBehaviour
{
public float plasticAmount = 0f;
public float metalAmount = 0;
public TextMeshProUGUI amountText;
public TextMeshProUGUI amountText2;

public int plastics = 0;
public int metals = 0;

public float metalPrice = 0;
public float metalBasePrice = 10;
public float metalPriceMultiplier = 1.1f;
public float metalProduction = .1f;

    public float plasticPrice = 0;
public float plasticBasePrice = 10;
public float plasticPriceMultiplier = 1.1f;
public float plasticProduction = .1f;

public TextMeshProUGUI buildText;
public TextMeshProUGUI buildText2;

    // Start is called before the first frame update
    void Start()
        {
         plasticPrice = plasticBasePrice;
        metalPrice = metalBasePrice;

        amountText.text = "0";
        amountText2.text = "0";

        buildText.text = $"Buy Plastic Upgrade${plasticPrice}";
        buildText2.text = $"Buy Metal Upgrade${metalPrice}";
        InvokeRepeating("MainLoop", 0f, .1f);
        }

        void MainLoop()
        {
            plasticAmount += plastics * plasticProduction;
            metalAmount += metals * metalProduction;
    }

      void Update()
        {
            amountText.text = plasticAmount.ToString("0");
        amountText2.text = metalAmount.ToString("0");
    }

    public void IncreaseNumber()
        {
            plasticAmount += 1;
    
    }

    public void IncreaseNumber1()
    {
        
        metalAmount += 1;
    }

    public void CollectPlastic()
        {
            if (plasticAmount >= plasticPrice)
            {

                plastics++;
                plasticAmount -= plasticPrice;
                plasticPrice = Mathf.Floor(plasticBasePrice * Mathf.Pow(plasticPriceMultiplier, plastics));
                buildText.text = $"Buy Plastic Upgrade ${plasticPrice}";
            }
        }

    public void CollectMetal()
    {
        if (metalAmount >= metalPrice)
        {

            metals++;
            metalAmount -= metalPrice;
            metalPrice = Mathf.Floor(metalBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
            buildText2.text = $"Buy Metal Upgrade ${metalPrice}";
        }
    }
}

