using UnityEngine;

namespace Nickel.NickelBalanace.script
{
    public class FoodDetect : MonoBehaviour
    {
        // Start is called before the first frame update
        public int ID;
        private float each=0;

        public GameObject bar;
        void Start()
        {
            bar.transform.localScale = new Vector3(0.18f, 0.02f, 0f);
        }
    

        // Update is called once per frame
        void Update()
        {
            Debug.Log(each);
            bar.transform.localScale = new Vector3(0.18f,0.92f*each/6f,0f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (each<6)
            {
                if (ID == 1)
                {
                    if (other.CompareTag("GrillFish"))
                    {
                        each++;
                    }
                }
                else if (ID == 2)
                {
                    if (other.CompareTag("Sushi"))
                    {
                        each++;
                    }
                }
            }
            
        }
    }

}
