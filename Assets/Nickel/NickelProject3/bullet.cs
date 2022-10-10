using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private GameObject enemy;

    public float bulletSpeed=1;
   
    
   
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        rb = transform.GetComponent<Rigidbody2D>();
        Vector2 direction = Vector2.MoveTowards(transform.position, enemy.transform.position, bulletSpeed);
        direction -= (Vector2)transform.position;
        rb.velocity = direction*5;

    }
}
