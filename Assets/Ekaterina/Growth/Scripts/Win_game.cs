using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ekaterina
{
    public class Win_game : MonoBehaviour
    {
        public Slider FoodBar;
        public Slider EnergyBar;
        public Slider HappinessBar;

        public Button Button;
        
        void Start () {
            if (SceneManager.GetActiveScene().name == "Ekaterina.Growth.Win")
            {
                Button btn = Button.GetComponent<Button>();
                btn.onClick.AddListener(TaskOnClick);
            }
        }

        void TaskOnClick(){
            SceneManager.LoadScene("Ekaterina.Growth.Main scene 1");
        }
        
        void Update()
        {
            if (FoodBar?.value == 100 && EnergyBar?.value == 100 && HappinessBar?.value == 100)
            {
                SceneManager.LoadScene("Ekaterina.Growth.Win");
            }
        }
    }
}
