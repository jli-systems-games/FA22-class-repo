using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{

    public float interval;

    private float timer;

    public GameObject[] bullets;

    public Transform firepoint;

    public bool hasStarted;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted)
        {
            /*  if(Input.anyKeyDown)
              {
                  hasStarted = true;
              } */
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {

                int bulletsIndex = Random.Range(0, bullets.Length);

                timer = 0;
                Instantiate(bullets[bulletsIndex], firepoint.position, Quaternion.identity);
            }

            Destroy(gameObject, 120f);
        }

        












    }
}
