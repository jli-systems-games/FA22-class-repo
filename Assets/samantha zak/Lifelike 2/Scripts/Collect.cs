using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace samantha_zak.Lifelike_2.Scripts
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