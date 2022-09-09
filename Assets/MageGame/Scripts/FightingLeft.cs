using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace maiproject
{
    public class FightingLeft : MonoBehaviour
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


        private void Start()
        {
            health = gameObject.GetComponent<Health>();
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector2(playerposition.position.x, positions[state].position.y);

            spriterenderer.sprite = sprites[state];




            //motion
            if (Input.GetKey(KeyCode.UpArrow))
            {
                state = 1;
                Debug.Log(transform.position);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                state = 2;
            }
            else
            {
                state = 0;
            }


            //shooting

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                Instantiate(projectile, firePosition.position, firePosition.rotation);

            }



            //shielding

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                health.shieldRate = shielding;
            }
            else
            {
                health.shieldRate = 0;
            }
        }
    }
}