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
        public float dead = -1;
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
            dead+= 1;
            DeadText.SetText("Unicorns killed: " + cloned.ToString());
        }
        public void bleedMessage(float n)
        {
            blood += n;
            bloodCOunt.SetText("Blood used: " + blood.ToString());
        }



    }
}
