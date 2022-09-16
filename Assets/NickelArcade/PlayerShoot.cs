using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;

    float timeUnitFire;
    NickelArcade.Player pm;

    // Start is called before the first frame update
    void Start()
    {
        pm = gameObject.GetComponent<NickelArcade.Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("Player1"))
        {
            if (Input.GetKeyDown(KeyCode.E) && timeUnitFire < Time.time)
            {
                Shoot();
                timeUnitFire = Time.time + fireRate;
            }
        }else if (this.gameObject.CompareTag("Player2"))
        {
            if(Input.GetKeyDown(KeyCode.RightShift) && timeUnitFire < Time.time)
            {
                Shoot();
                timeUnitFire = Time.time + fireRate;
            }
        }


    }

    void Shoot()
    {
        //float angle = pm.p1isFacingRight ? 0f : 180f;
        float angle = 0;
        if (transform.localScale.x < 0)
        {
            angle = 180;
        }else if (transform.localScale.x > 0)
        {
            angle = 0;
        }
        Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }
}
