using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{

    public GameObject firePoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireShotgun());
    }
    IEnumerator FireShotgun()
    {

        float rotationAngle = -30f;
        for (int i=0;i<100;i++)
        {
            for(int j=0;j<3;j++)
            {
                switch(j)
                {
                    case 0:
                        CreatBullet(rotationAngle, firePoint.transform.position);
                        rotationAngle += 30f;
                        break;

                    case 1:
                        CreatBullet(rotationAngle, firePoint.transform.position);
                        rotationAngle += 30f;
                        break;

                    case 2:
                        CreatBullet(rotationAngle, firePoint.transform.position);
                        rotationAngle = -30f;
                        break;


                }
            }

            yield return new WaitForSeconds(1f);


        }



    }

    private void CreatBullet (float rotationAngle,Vector3 firePosition)
    {
        Instantiate(bullet, firePosition, Quaternion.AngleAxis(rotationAngle, Vector3.forward));
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
