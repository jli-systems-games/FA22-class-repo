using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Bloom
{



    public class WGplayermovement : MonoBehaviour
    {


        public float moveSpeed = 5f;
        public Rigidbody rb;
        Vector3 movement;
        public GameObject effect1;
        public GameObject effect2;
        private MeshRenderer _meshRenderer;
        private Collider _Collider;
        public GameObject player;
        public GameObject stage;
        public GameObject arrows;
        public GameObject bg;
        void Start()
        {
            _meshRenderer = transform.GetComponent<MeshRenderer>();
            _Collider = transform.GetComponent<Collider>();
        }


        void Update()
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");



        }


        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Enemy")
            {


                effect1.SetActive(true);
                effect2.SetActive(true);
                bg.SetActive(true);
                Destroy(player, 2.5f);
                Destroy(stage, 2.5f);
                Destroy(arrows, 2.5f);


            }


        }
    }

}