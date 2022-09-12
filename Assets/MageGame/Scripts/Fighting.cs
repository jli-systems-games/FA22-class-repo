using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace maiproject { 
public class Fighting : MonoBehaviour
{
        public Transform playerposition;
    public Transform firePosition;
    public GameObject projectile;
        public Transform[] positions;
        public Health health;
        public int shielding;
        public Sprite[] sprites;
        public SpriteRenderer spriterenderer;
        public int state = 0;
        public GameObject shield;
        public int rotationDegrees;
        public List<KeyCode> keycodes;
        public GameObject winNote;

        public bool isAlive;

        //public KeyCode[] keycodes;

        private void Start()
        {
           health= gameObject.GetComponent<Health>();

            isAlive = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (isAlive == true) { 

            transform.position = new Vector2(playerposition.position.x, positions[state].position.y);

            spriterenderer.sprite = sprites[state];





            if (Input.GetKey(keycodes[0]))
            {
                state = 1;
                Debug.Log(transform.position);
            }
            else if (Input.GetKey(keycodes[1]))
            {
                state = 2;
            }
            else
            {
                state = 0;
            }




            

         //shielding
            if (Input.GetKey(keycodes[3]))
            {
                health.shieldRate = shielding;
                shield.SetActive(true);
            } else
            {
                health.shieldRate = 0;
                shield.SetActive(false);

                if (Input.GetKeyDown(keycodes[2]))
                {

                    Instantiate(projectile, firePosition.position, firePosition.rotation);

                }



            }

                //shooting

            }




            if (health.health <= 0)
            {
                Debug.Log("Dead");
                isAlive = false;
                spriterenderer.sprite = sprites[3];
                transform.position = new Vector2(playerposition.position.x, positions[2].position.y);
                //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.eulerAngles + new Vector3(0, 0, 90f)), 0.8f);
                Vector3 newRotation = new Vector3(0, 0, rotationDegrees);
                transform.eulerAngles = newRotation;
                winNote.SetActive(true);
            }
        }
}
}
