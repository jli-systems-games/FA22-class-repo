using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace WeiGame
{
    public class Weibullet3 : MonoBehaviour
    {

        public float speed;
        //public GameObject collectedEffect;

        private MeshRenderer _meshRenderer;
        private Collider _Collider;


        void Start()
        {
            _meshRenderer = transform.GetComponent<MeshRenderer>();
            _Collider = transform.GetComponent<Collider>();
            // public GameObject snake;
        }


        void Update()
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _meshRenderer.enabled = false;
                _Collider.enabled = false;

                //collectedEffect.SetActive(true);

                Destroy(gameObject, 0f);
            }


        }


    }
}