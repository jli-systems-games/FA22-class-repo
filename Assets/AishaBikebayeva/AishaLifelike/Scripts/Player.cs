using UnityEngine;

namespace AishaBikebayeva.AishaLifelike.Scripts
{
    public class Player : MonoBehaviour
    {

        public float speed;
        public float jump; 
        public float turnSmoothTime = .1f;
        public float airtime;   
        public Transform feet;
        
        Vector3 dir;
        Vector3 moveDir;
        float hor;
        float ver;
        float targetAngle;
        float angle;
        float turnSmoothVelocity;
        float fallMultiplier = 2.5f;
        float lowJumpMultiplier = 2;
        float groundDistance = .4f;
        float jumpTimer;
        bool moving;    
        bool grounded;
        bool jumping;

        Animator anim;
        Camera cam;
        Rigidbody rb;
        CharacterController controller;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            anim = GetComponentInChildren<Animator>();
            cam = Camera.main;
            //anim.SetTrigger("stopskateboarding");
            //controller = GetComponent<CharacterController>()
        }


        private void Update()
        {

            //_______________________Move_________________________________________________
            if (ver < 0)
            {
                hor = -Input.GetAxisRaw("Horizontal");//-----fixes invert when moving backwards
            }
            else
            {
                hor = Input.GetAxisRaw("Horizontal");
            }

            ver = Input.GetAxisRaw("Vertical");

            dir = new Vector3(hor, 0, ver).normalized;

            if (dir.magnitude > .01f)
            {
                
                if (ver < 0)//-----fixes invert when moving backwards
                {
                    moveDir = GetAngle(Vector3.back);
                }
                else
                {
                    moveDir = GetAngle(Vector3.forward);
                }
            }

            if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
            {
                anim.SetTrigger("skateboarding");
            }

            


            //_______________________Jump_________________________________________________

            /* if (Input.GetButtonDown("Jump") && grounded)
            {
                rb.drag = 1;
                jumping = true;

            }
            if (Input.GetButton("Jump") && grounded)
            {
                jumpTimer += Time.deltaTime;

                if (jumpTimer > airtime)
                {
                    jumping = false;
                    jumpTimer = 0;
                    rb.drag = 10;
                }    
                //anim.SetTrigger("jump");
            }

            if (Input.GetButtonUp("Jump"))
            {
                jumping = false;

            }*/

            grounded = CheckIfGrounded();

            if (Input.GetButtonDown("Jump") && grounded)
            {
                anim.SetTrigger("fliptrick");
                rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
                
            }
        if (grounded)
            {
                //rb.drag = 10;
                //speed = 10000;
                
            }
            else
            {
                //rb.drag = 1f;
                //speed = 800;
            }

            anim.SetFloat("moving", dir.magnitude);
            anim.SetFloat("speed", (Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z)));
            anim.SetFloat("jumpHeight", rb.velocity.y);
        }

        private Vector3 GetAngle(Vector3 forward)//-------Returns direction to move towards
        {
            targetAngle = Mathf.Atan2(dir.x , dir.y) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;

            angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0, angle, 0);

            return Quaternion.Euler(0, targetAngle, 0) * forward;
        }
        // Update is called once per frame
        void FixedUpdate()
        {

            if (dir.magnitude > .01f)
            {
                //rb.velocity = (moveDir.normalized * speed * Time.deltaTime);

                rb.AddForce(moveDir.normalized * speed * Time.deltaTime,ForceMode.Force);
                //rb.MovePosition(transform.position + moveDir.normalized * speed * Time.fixedDeltaTime);            
            }

            rb.AddForce(Physics.gravity * rb.mass);
        /* if (jumping)
            {
                Jump();
            }*/
        }

        public void Jump()
        {
            rb.AddForce(Vector3.up * jump * Time.deltaTime);
        }

        private bool CheckIfGrounded()
        {
            return Physics.Raycast(feet.position, Vector3.down, groundDistance);
        }


    }
}