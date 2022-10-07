using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace godzillabanana { 
public class TextMango : MonoBehaviour
{
        public TMP_Text clonedText;
        public TMP_Text DeadText;
        public TMP_Text bloodCOunt;
        public float dead = 0;
        public int cloned = 0;
        public float blood = 0;
        // Start is called before the first frame update
      



       public void cloneMessage()
        {
            cloned+= 1;
            clonedText.SetText("Unicorns cloned: "+cloned.ToString());
        }

        public void killMessage()
        {
             //Debug.Log("worked");
            dead+= 1;

            DeadText.SetText("Unicorns slayed: " + (dead+1).ToString());
        
        }
        public void bleedMessage()
        {
            
            blood += 5;
            bloodCOunt.SetText("Blood used: " + blood.ToString());
        }



    }
}
