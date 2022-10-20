using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Sam
{
    public class Collect : MonoBehaviour
    {
        int fluid = 0;
            
        [SerializeField] Text LightText;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("collectibleSam")){
                Destroy(other.gameObject);
                fluid++;
                //Debug.Log("collectibleSam" + fluid);
                LightText.text = "Lights: " + fluid;
            }
        }
        public void Update()
        {
            if (fluid >= 13){
                SceneManager.LoadScene("End");
            }
            else
            {
                Debug.Log("didn't work");
            }
        }
    }
}