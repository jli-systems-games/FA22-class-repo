using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecycleClicker : MonoBehaviour
{
public float plasticAmount = 0f;
public float metalAmount = 0f;
    public float electronicAmount = 0f;
    public float bookAmount = 0f;

public TextMeshProUGUI amountText;
public TextMeshProUGUI amountText2;
public TextMeshProUGUI amountText3;
public TextMeshProUGUI amountText4;

    public int plastics = 0;
public int metals = 0;
    public int electronics = 0;
    public int books = 0;



    public float plasticPrice = 0;
public float plasticBasePrice = 10;
public float plasticPriceMultiplier = 1.1f;
public float plasticProduction = .1f;

    public float metalPrice = 0;
    public float metalBasePrice = 10;
    public float metalPriceMultiplier = 1.1f;
    public float metalProduction = .1f;

    public float electronicPrice = 0;
    public float electronicBasePrice = 10;
    public float electronicPriceMultiplier = 1.1f;
    public float electronicProduction = .1f;

    public float bookPrice = 0;
    public float bookBasePrice = 10;
    public float bookPriceMultiplier = 1.1f;
    public float bookProduction = .1f;

    public TextMeshProUGUI buildText;
public TextMeshProUGUI buildText2;
    public TextMeshProUGUI buildText3;
    public TextMeshProUGUI buildText4;

    // Start is called before the first frame update
    void Start()
        {
         plasticPrice = plasticBasePrice;
        metalPrice = metalBasePrice;
        electronicPrice = electronicBasePrice;
        bookPrice = bookBasePrice;


        amountText.text = "Plastics:0";
        amountText2.text = "Metals:0";
        amountText3.text = "Electronics:0";
        amountText4.text = "Books:0";

        buildText.text = $"Plastic${plasticPrice}";
        buildText2.text = $"Plastic${plasticPrice} Metal${metalPrice}";
        buildText3.text = $"Plastic${plasticPrice} Metal${metalPrice} Electronics${electronicPrice}";
        buildText4.text = $"Plastic${plasticPrice} Metal${metalPrice} Electronic${electronicPrice}Book${bookPrice}";
        InvokeRepeating("MainLoop", 0f, .1f);
        }

        void MainLoop()
        {
            plasticAmount += plastics * plasticProduction;
            metalAmount += metals * metalProduction;
        electronicAmount += electronics * electronicProduction;
        bookAmount += books * bookProduction;
    }

      void Update()
        {
            amountText.text = plasticAmount.ToString("Plastics:0");
        amountText2.text = metalAmount.ToString("Metals:0");
        amountText3.text = electronicAmount.ToString("Electronics:0");
        amountText4.text = bookAmount.ToString("Books:0");
    }

    public void IncreaseNumber()
        {
            plasticAmount += 1;
    
    }

    public void IncreaseNumber1()
    {
        
        metalAmount += 1;
    }

    public void IncreaseNumber2()
    {

        electronicAmount += 1;
    }

    public void IncreaseNumber3()
    {

        bookAmount += 1;
    }


    public void PlasticUpgrade()
        {
            if (plasticAmount >= plasticPrice)
            {

                plastics++;
                plasticAmount -= plasticPrice;
                plasticPrice = Mathf.Floor(plasticBasePrice * Mathf.Pow(plasticPriceMultiplier, plastics));
                buildText.text = $"Buy Plastic Upgrade ${plasticPrice}";
            }
        }

    public void PlasticUpgrade1()
    {
        if (plasticAmount>= plasticPrice && metalAmount >= metalPrice)
        {
            plastics++;
            plasticAmount -= plasticPrice;
            metalAmount -= metalPrice;
            metalPrice = Mathf.Floor(metalBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
            buildText2.text = $"Plastic${plasticPrice}Metal${metalPrice}";
        }
    }

    
    public void PlasticUpgrade2()
    {
        if (plasticAmount >= plasticPrice && metalAmount >= metalPrice && electronicAmount >= electronicPrice)
        {
            plastics++;
            metalAmount -= metalPrice;
            plasticAmount -= plasticPrice;
            electronicAmount -= electronicPrice;
            metalPrice = Mathf.Floor(metalBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
            buildText3.text = $"Plastic${plasticPrice}Metal:${metalPrice}Electronics${electronicPrice}";
        }
    }

    public void PlasticUpgrade3()
    {
        if (plasticAmount >= plasticPrice && metalAmount >= metalPrice && electronicAmount >= electronicPrice && bookAmount >= bookPrice)
        {
            plastics++;
            metalAmount -= metalPrice;
            plasticAmount -= plasticPrice;
            electronicAmount -= electronicPrice;
            bookAmount -= bookPrice;
            metalPrice = Mathf.Floor(metalBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
            buildText4.text = $"Plastic${plasticPrice}Metal${metalPrice}Electronic${electronicPrice}Book${bookPrice}";
        }
    }
        public void MetalUpgrade()
    {
        if (metalAmount >= metalPrice)
        {

            metals++;
            metalAmount -= metalPrice;
            metalPrice = Mathf.Floor(metalBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
            buildText.text = $"Buy Metal Upgrade ${metalPrice}";
        }
    }



    public void CollectElectronic()
    {
        if (electronicAmount >= electronicPrice)
        {

            electronics++;
            electronicAmount -= electronicPrice;
            electronicPrice = Mathf.Floor(electronicBasePrice * Mathf.Pow(electronicPriceMultiplier, electronics));
            buildText2.text = $"Buy Electronic Upgrade ${electronicPrice}";
        }

    }
    public void CollectBook()
    {
        if (bookAmount >= bookPrice)
        {

           books++;
            bookAmount -= bookPrice;
            bookPrice = Mathf.Floor(bookBasePrice * Mathf.Pow(bookPriceMultiplier, books));
            buildText2.text = $"Buy Book Upgrade ${bookPrice}";
        }

    }
}


