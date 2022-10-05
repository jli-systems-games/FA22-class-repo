using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HectorRodriguez
{
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

        public Animator scoreAnim;

        public float trashBasePrice = 10;

        public float plasticPrice = 0;
        public float plasticPriceMultiplier = 1.1f;
        public float plasticProduction = .1f;

        public float metalPrice = 0;
        public float metalPriceMultiplier = 1.1f;
        public float metalProduction = .1f;

        public float electronicPrice = 0;
        public float electronicPriceMultiplier = 1.1f;
        public float electronicProduction = .1f;

        public float bookPrice = 0;
        public float bookPriceMultiplier = 1.1f;
        public float bookProduction = .1f;

        public TextMeshProUGUI buildTextplastic;
        public TextMeshProUGUI buildTextplastic2;
        public TextMeshProUGUI buildTextplastic3;
        public TextMeshProUGUI buildTextplastic4;

        public TextMeshProUGUI buildTextmetal;
        public TextMeshProUGUI buildTextmetal2;
        public TextMeshProUGUI buildTextmetal3;
        public TextMeshProUGUI buildTextmetal4;

        public TextMeshProUGUI buildTextelectronic;
        public TextMeshProUGUI buildTextelectronic2;
        public TextMeshProUGUI buildTextelectronic3;
        public TextMeshProUGUI buildTextelectronic4;


        public TextMeshProUGUI buildTextbook;
        public TextMeshProUGUI buildTextbook2;
        public TextMeshProUGUI buildTextbook3;
        public TextMeshProUGUI buildTextbook4;



        // Start is called before the first frame update
        void Start()
        {
            plasticPrice = trashBasePrice;
            metalPrice = trashBasePrice;
            electronicPrice = trashBasePrice;
            bookPrice = trashBasePrice;


            amountText.text = "Plastics:0";
            amountText2.text = "Metals:0";
            amountText3.text = "Electronics:0";
            amountText4.text = "Books:0";
            //plastic
            buildTextplastic.text = $"Plastic$s{plasticPrice}";
            buildTextplastic2.text = $"Plastics${plasticPrice} Metasl${metalPrice}";
            buildTextplastic3.text = $"Plastics${plasticPrice} Metals${metalPrice} Electronics${electronicPrice}";
            buildTextplastic4.text = $"Plastics${plasticPrice} Metals${metalPrice} Electronics${electronicPrice} Books${bookPrice}";
            //metal
            buildTextmetal.text = $"Metal{metalPrice}";
            buildTextmetal2.text = $"Metals${metalPrice}Plastics$ {plasticPrice}";
            buildTextmetal3.text = $"Metals${metalPrice}Plastics$ {plasticPrice}Electronics$ {electronicPrice}";
            buildTextmetal4.text = $"Metals${metalPrice}Plastic$s {plasticPrice}Electronics$ {electronicPrice}Books$ {bookPrice}";
            //electronic
            buildTextelectronic.text = $"Electronics${electronicPrice}";
            buildTextelectronic2.text = $"Electronics$ {electronicPrice}Plastics$ {plasticPrice}";
            buildTextelectronic3.text = $"Electronics$ {electronicPrice}Plastics$ {plasticPrice}Metals$ {metalPrice} ";
            buildTextelectronic4.text = $"Electronics$ {electronicPrice}Plastics$ {plasticPrice}Metals$ {metalPrice}Books$ {bookPrice}";

            //book
            buildTextbook.text = $"Books${bookPrice}";
            buildTextbook2.text = $"Books$ {bookPrice}Plastic$ {plasticPrice}";
            buildTextbook3.text = $"Books$ {bookPrice}Plastic$ {plasticPrice}Metal$ {metalPrice} ";
            buildTextbook4.text = $"Books$ {bookPrice}Plastic$ {plasticPrice}Metal$ {metalPrice}Electronics$ {electronicPrice}";


            InvokeRepeating("MainLoop", 0f, .1f);
        }
        public static RecycleClicker instance;
        void Awake()
        {
            instance = this;
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

        public void Substractplastic()
        {

            plasticAmount -= 10;
        }

        public void IncreasePlastic()
        {
            plasticAmount += 1;
            
        }

        public void IncreaseMetal()
        {

            metalAmount += 1;
        }

        public void IncreaseElectronic()
        {

            electronicAmount += 1;
        }

        public void IncreaseBook()
        {

            bookAmount += 1;
        }


        public void PlasticUpgrade()
        {
            if (plasticAmount >= plasticPrice)
            {

                plastics++;
                plasticAmount -= plasticPrice;
                plasticPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(plasticPriceMultiplier, plastics));
                buildTextplastic.text = $"Plastic${plasticPrice}";
            }
        }

        public void PlasticUpgrade1()
        {
            if (plasticAmount >= plasticPrice && metalAmount >= metalPrice)
            {
                plastics++;
                electronicAmount += 50;
                plasticAmount -= plasticPrice;
                metalAmount -= metalPrice;
                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextplastic2.text = $"Plastic$ {plasticPrice} Metal${metalPrice}";
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
               bookAmount += 50;
                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextplastic3.text = $" Plastic${plasticPrice} Metal:${metalPrice} Electronics${electronicPrice}";
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
                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextplastic4.text = $"Plastic${plasticPrice} Metal${metalPrice} Electronic${electronicPrice}Book${bookPrice}";
            }
        }
        public void MetalUpgrade()
        {
            if (metalAmount >= metalPrice)
            {

                metals++;
                metalAmount -= metalPrice;
                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextmetal.text = $" Metal${metalPrice}";
            }
        }

        public void MetalUpgrade1()
        {
            if (metalAmount >= metalPrice && plasticAmount >= plasticPrice)
            {

                metals++;
                metalAmount -= metalPrice;
                plasticAmount -= plasticPrice;

                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextmetal2.text = $"Metal${metalPrice} Plastic${plasticPrice}";
            }
        }
        public void MetalUpgrade2()
        {
            if (metalAmount >= metalPrice && plasticAmount >= plasticPrice && electronicAmount >= electronicPrice)
            {

                metals++;
                metalAmount -= metalPrice;
                plasticAmount -= plasticPrice;
                electronicAmount -= electronicPrice;
                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextmetal3.text = $" Metal${metalPrice} Plastic${plasticPrice} Electronics${electronicPrice}";
            }
        }
        public void MetalUpgrade3()
        {
            if (metalAmount >= metalPrice && plasticAmount >= plasticPrice && bookAmount >= bookPrice)
            {

                metals++;
                metalAmount -= metalPrice;
                bookAmount -= bookPrice;
                electronicAmount -= electronicPrice;
                metalPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(metalPriceMultiplier, metals));
                buildTextmetal3.text = $"Metal${metalPrice}Plastic${plasticPrice}  Electronic${electronicPrice}Book${bookPrice}";
            }
        }

        public void ElectronicUpgrade()
        {
            if (electronicAmount >= electronicPrice)
            {

                electronics++;
                electronicAmount -= electronicPrice;
                electronicPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(electronicPriceMultiplier, electronics));
                buildTextelectronic.text = $"Electronic${electronicPrice}";
            }
        }
        public void ElectronicUpgrade1()
        {
            if (electronicAmount >= electronicPrice && plasticAmount >= plasticPrice)
            {

                electronics++;
                plasticAmount -= plasticPrice;
                electronicAmount -= electronicPrice;
                electronicPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(electronicPriceMultiplier, electronics));
                buildTextelectronic2.text = $"Electronics${electronicPrice} Plastic${plasticPrice}";
            }
        }
        public void ElectronicUpgrade2()
        {
            if (electronicAmount >= electronicPrice && plasticAmount >= plasticPrice && metalAmount >= metalPrice && electronicAmount >= electronicPrice)
            {

                electronics++;
                plasticAmount -= plasticPrice;
                metalAmount -= metalPrice;
                electronicAmount -= electronicPrice;
                electronicPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(electronicPriceMultiplier, electronics));
                buildTextelectronic3.text = $"Electronics${electronicPrice} Plastic${plasticPrice}Metal${metalPrice} ";
            }
        }
        public void ElectronicUpgrade3()
        {
            if (electronicAmount >= electronicPrice && plasticAmount >= plasticPrice && metalAmount >= metalPrice && electronicAmount >= electronicPrice && bookAmount >= bookPrice)
            {

                electronics++;
                plasticAmount -= plasticPrice;
                metalAmount -= metalPrice;
                electronicAmount -= electronicPrice;
                bookAmount -= bookPrice;
                electronicPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(electronicPriceMultiplier, electronics));
                buildTextelectronic4.text = buildTextelectronic4.text = $"Electronics${electronicPrice} Plastic${plasticPrice}Metal${metalPrice}Book${bookPrice}";
            }
        }

        public void BookUpgrade()
        {
            if (bookAmount >= bookPrice)
            {
                if (bookAmount >= bookPrice)
                {

                    books++;
                    bookAmount -= bookPrice;
                    bookPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(bookPriceMultiplier, books));
                    buildTextbook.text = $"Book${bookPrice}";
                }
            }
        }

        public void BookUpgrade1()
        {
            if (bookAmount >= bookPrice && plasticAmount >= plasticPrice)
            {
                if (bookAmount >= bookPrice)
                {

                    books++;
                    bookAmount -= bookPrice;
                    plasticAmount -= plasticPrice;
                    bookPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(bookPriceMultiplier, books));
                    buildTextbook2.text = $"Books${bookPrice} Plastic${plasticPrice}";
                }
            }
        }
        public void BookUpgrade2()
        {
            if (bookAmount >= bookPrice && plasticAmount >= plasticPrice && electronicAmount >= electronicPrice)
            {
                if (bookAmount >= bookPrice)
                {

                    books++;
                    bookAmount -= bookPrice;
                    plasticAmount -= plasticPrice;
                    electronicAmount -= electronicPrice;
                    bookPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(bookPriceMultiplier, books));
                    buildTextbook3.text = $"Books${bookPrice} Plastic${plasticPrice}Metal${metalPrice} ";
                }
            }
        }
        public void BookUpgrade3()
        {
            if (bookAmount >= bookPrice && plasticAmount >= plasticPrice && electronicAmount >= electronicPrice)
            {
                if (bookAmount >= bookPrice)
                {

                    books++;
                    bookAmount -= bookPrice;
                    bookPrice = Mathf.Floor(trashBasePrice * Mathf.Pow(bookPriceMultiplier, books));
                    buildTextbook4.text = $"Books${bookPrice} Plastic${plasticPrice}Metal${metalPrice} Electronics${electronicPrice}";
                }
            }
        }
    }

}
