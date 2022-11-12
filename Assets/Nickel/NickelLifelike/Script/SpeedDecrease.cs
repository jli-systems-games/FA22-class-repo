using UnityEngine;

namespace Nickel.NickelLifelike.Script
{
    public class SpeedDecrease : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(PathFollower.moveSpeed);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("enter");
            if (collision.CompareTag("Enemy"))
            {
                collision.GetComponent<PathFollower>().moveSpeed = 0.5f;
                
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                collision.GetComponent<PathFollower>().moveSpeed = 1f;
            }
        }
    }

}

