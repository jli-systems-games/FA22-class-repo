using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NickelArcade
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private float p1direction = 0f;
        private float p2direction = 0f;

        public int playerId;
        [SerializeField] private float speed = 15f;

        [HideInInspector] public bool p1isFacingRight=true;
        [HideInInspector] public bool p2isFacingRight=true;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            p1direction = Input.GetAxis("HorizontalPlayer1");
            p2direction = Input.GetAxis("HorizontalPlayer2");

            if (playerId == 1)
            {
                if (p1direction > 0f)
                {
                    transform.localScale = new Vector2(3.77958751f, 3.97851276f);
                    p1isFacingRight = true;
                }
                else if (p1direction < 0f)
                {
                    transform.localScale = new Vector2(-3.77958751f, 3.97851276f);
                    p1isFacingRight = false;
                }
            }else if (playerId == 2)
            {
                if (p2direction > 0f)
                {
                    transform.localScale = new Vector2(3.88172626f, 3.88172626f);
                    p2isFacingRight = true;
                }
                else if (p2direction < 0f)
                {
                    transform.localScale = new Vector2(-3.88172626f, 3.88172626f);
                    p2isFacingRight = false;
                }
            }
            
            _rb.velocity = new Vector2(Input.GetAxis("HorizontalPlayer" + playerId), Input.GetAxis("VerticalPlayer" +playerId)) * speed;
            
        }
    }
}