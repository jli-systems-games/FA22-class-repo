using UnityEngine;

namespace Nickel.NickelLifelike.Script
{
    public class Thorn : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Debug.Log("1");
            if (collision.CompareTag("Enemy"))
            {
                //Debug.Log("enter");
                collision.GetComponent<EnemyHealth>().ThornDamage();
            }
            
        }
    }

}

