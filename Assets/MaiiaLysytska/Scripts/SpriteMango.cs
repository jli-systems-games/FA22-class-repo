using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace godzillabanana
{
    public class SpriteMango : MonoBehaviour
    {

        public Sprite[] uniSPrites;
        public int spriteNumber;
        public float randomNum;
        public Sprite currentSprite;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void spritePick()
        {

            //note: rn there are 8
            //sprites
            randomNum = Random.Range(0, 100);




            if (randomNum <= 15)
            {
                spriteNumber = 0;
            }
            if (randomNum >= 16 && randomNum <= 30)
            {
                spriteNumber = 1;
            }
            if (randomNum >= 31 && randomNum <= 45)
            {
                spriteNumber = 2;
            }

            if (randomNum >= 46 && randomNum <= 55)
            {
                spriteNumber = 3;
            }
            if (randomNum >= 56 && randomNum <= 65)
            {
                spriteNumber = 4;
            }
            if (randomNum >= 66 && randomNum <= 75)
            {
                spriteNumber = 5;
            }
            if (randomNum >= 76 && randomNum <= 85)
            {
                spriteNumber = 6;
            }
            if (randomNum >= 86 && randomNum <= 94)
            {
                spriteNumber = 7;
            }

            if (randomNum > 95) { spriteNumber = 8; }

            currentSprite = uniSPrites[spriteNumber];
        }
    }
}