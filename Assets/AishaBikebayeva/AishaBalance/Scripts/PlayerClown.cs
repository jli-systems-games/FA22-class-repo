using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AishasCircus{

    public class PlayerClown : MonoBehaviour
    {
        AudioSource jumpsound;
        public float speed;
        public float jumpPower;
        public float jumpTime;
        public bool isGrounded = false;
        public float sideDistance = .4f;
        public LayerMask sideMask;
        public LayerMask ground;
        //public Transform feet;
        public Transform body;
        public Transform leftSide;
        public Transform rightSide;
        public Collider2D playerCollider;
        [HideInInspector] public bool stopped;


        private float hor;
        public float groundDistance = .01f;
        private float jump;
        private float jumpTimeCounter;
        int direction = 1;
        bool isJumping;


        Rigidbody2D rb;
        public Animator clownsheet;


        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            clownsheet = gameObject.GetComponent<Animator>();
            direction = 1;
            jumpsound = GetComponent<AudioSource>();
            clownsheet.enabled = false;
        }

        private void Update()
        {
            hor = Input.GetAxis("Horizontal");
            // ver = Input.GetAxis("Vertical");

            isGrounded = CheckIfGrounded();



            if (CheckLeft())
            {
                if (rb.velocity.x < 0)
                {
                    rb.velocity = new Vector2(0, rb.velocity.y);

                    clownsheet.Play("ClownPlayerWalk");
                    clownsheet.enabled = true;
                }
            }

            if (CheckRight())
            {
                if (rb.velocity.x > 0)
                {
                    rb.velocity = new Vector2(0, rb.velocity.y);

                    clownsheet.Play("ClownPlayerWalk");
                    clownsheet.enabled = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                // isJumping = true;
                // jumpTimeCounter = jumpTime;
                //anim.SetTrigger("jump");
                rb.velocity = Vector2.up * jumpPower;
            }

            // if (Input.GetKey(KeyCode.Space) && isJumping == true)
            // {


            //     if (jumpTimeCounter > 0)
            //     {
            //         rb.velocity = Vector2.up * jumpPower;
            //         //rb.AddForce(Vector2.up * jumpPower);

            //         jumpTimeCounter -= Time.deltaTime;
            //         jumpsound.Play();
            //     }
            //     else
            //     {
            //         isJumping = false;
            //     }

            // }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                isJumping = false;
            }

            CharacterDirectionCheck(hor);

            // Attack();


            //anim.SetFloat("velocityX", Mathf.Abs(rb.velocity.x));
            //anim.SetFloat("velocityY", rb.velocity.y);
            //anim.SetBool("isGrounded", isGrounded);
        }


        void FixedUpdate()
        {
            Move();
        }

        public void Move()
        {
            rb.velocity = new Vector2(hor * -speed, rb.velocity.y);
            //rb.AddForce(new Vector2(hor * speed, 0));
        }

        private bool CheckIfGrounded()
        {
            if (Physics2D.Raycast(playerCollider.bounds.min, Vector2.down, groundDistance, ground) /*&& Mathf.Abs(rb.velocity.y) < .1f*/)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CheckLeft()
        {
            if (Physics2D.Raycast(leftSide.position, Vector2.left, sideDistance, sideMask) /*&& Mathf.Abs(rb.velocity.y) < .1f*/)
            {

                return true;
                clownsheet.Play("ClownPlayerWalk");
                clownsheet.enabled = true;
            }
            else
            {

                return false;
            }
        }

        private bool CheckRight()
        {
            if (Physics2D.Raycast(leftSide.position, Vector2.right, sideDistance, sideMask) /*&& Mathf.Abs(rb.velocity.y) < .1f*/)
            {

                return true;
                clownsheet.Play("ClownPlayerWalk");
                clownsheet.enabled = true;
            }
            else
            {

                return false;
            }
        }

        // private void Attack()
        // {
        //     if (Input.GetMouseButtonDown(1))
        //     {
        //         clownsheet.SetTrigger("Attack");
        //     }
        // }

        private void CharacterDirectionCheck(float xSpeed)
        {
            // If the sign of the character's horizontal speed
            // is different from the sign of the direction they are facing in,
            // then we need to flip the character to face the other direction.
            if (-xSpeed * direction < 0.0f)
            {
                // Flip the direction the character is facing in
                direction *= -1;

                // Calculate how many degrees the character needs to be rotated
                // around the Y-axis to face in that direction
                int rotation = (direction < 0.0f)
                    ? 180
                    : 0;

                // Apply the new rotation to the character's transform
                transform.eulerAngles = new Vector3(0, rotation, 0);
            }
        }

    }

}