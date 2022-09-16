using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{

    public float speed;
    //public GameObject collectedEffect;

    private SpriteRenderer _spriteRenderer;
    private Collider2D _Collider2D;

   
    void Start()
    {
        _spriteRenderer = transform.GetComponent <SpriteRenderer> ();
        _Collider2D = transform.GetComponent<Collider2D>();
       // public GameObject snake;
    }

  
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _spriteRenderer.enabled = false;
            _Collider2D.enabled = false;

            //collectedEffect.SetActive(true);

            Destroy(gameObject, 0f);
        }
    }




}
