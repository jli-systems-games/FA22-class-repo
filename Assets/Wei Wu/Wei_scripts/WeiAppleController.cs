using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeiAppleController : MonoBehaviour
{

    public float speed;
    public GameObject collectedEffect;
    public GameObject collectedEffect2;



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



    private void CreatBullet(float rotationAngle, Vector3 firePosition)
    {
        Instantiate(collectedEffect, firePosition, Quaternion.AngleAxis(rotationAngle, Vector3.forward));
    }



    
            private void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.tag == "Player")
        {
            _meshRenderer.enabled = false;
            _Collider.enabled = false;

            collectedEffect.SetActive(true);
            collectedEffect2.SetActive(false);

            Destroy(gameObject, 0.3f);


        }

        if (other.gameObject.tag == "Finish")
        {
            _meshRenderer.enabled = false;
            _Collider.enabled = false;


            collectedEffect.SetActive(true);
            collectedEffect2.SetActive(false);

            Destroy(gameObject, 0.3f);
                
        }

            


        
    }
}
