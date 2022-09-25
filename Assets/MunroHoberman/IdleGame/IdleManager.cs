using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Munro.IdleGame {
    public class IdleManager : MonoBehaviour
    {
        public double growAmount=0f;
        public TextMeshProUGUI amountText;
        
        // Start is called before the first frame update
        void Start()
        {
            
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }

        public void IncreaseNumber()
        {
            growAmount += 1;
            amountText.text = growAmount.ToString();
        }
        
    }
}