using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

namespace EkaterinaFunButton
{
    public class Taps : MonoBehaviour
    {
        public static int taps = 0;
        
        public TextMeshProUGUI textTaps;
        public AudioSource playSound;
        public Button button;

        void Start () 
        {
            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick()
        {
            Debug.Log ("You have clicked the button!");
            taps++;
            playSound.Play();
            PlayerPrefs.SetInt("Taps", taps);
            textTaps.text = "Taps: " + taps.ToString();
        }

        // private void Start()
        // {
        //     if (Input.GetMouseButtonDown(0))
        //     {
        //         taps++;
        //         playSound.Play();
        //         PlayerPrefs.SetInt("Taps", taps);
        //         textTaps.text = "Taps: " + taps.ToString();
        //     }
        //     if (PlayerPrefs.HasKey("Taps"))
        //     {
        //         taps = PlayerPrefs.GetInt("Coins");
        //         textTaps.text = "Taps: " + taps.ToString();
        //     }
        //     else
        //     {
        //         PlayerPrefs.SetInt("Taps", 0);
        //     }
    }
}

