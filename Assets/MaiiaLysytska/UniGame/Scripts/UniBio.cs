using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace godzillabanana { 
public class UniBio : MonoBehaviour
{

        public Sprite[] unicorns;
        public string[] texts;
        public string[] names;
        public TMP_Text biotext;
        public TMP_Text uniName;
        public Image bioPic;
        public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            bioPic.sprite = unicorns[counter];
            biotext.SetText(texts[counter]);
            uniName.SetText(names[counter]);
  }


        public void Increase()
        {
            counter++;
            if (counter > 7)
            {
                counter = 0;
            }
        }


        public void Decrease()
        {
            counter--;
            if (counter < 0)
            {
                counter = 7;
            }
        }
    }
}