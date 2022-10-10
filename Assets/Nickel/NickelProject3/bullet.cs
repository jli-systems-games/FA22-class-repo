using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    public float bulletSpeed;
    private Vector2 enemyPosition;
    void Start()
    {
        enemyPosition = enemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, enemyPosition, bulletSpeed * Time.deltaTime);
    }
}
