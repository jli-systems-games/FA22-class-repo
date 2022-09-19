using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeiFirePoint5 : MonoBehaviour
{

    public GameObject firePoint;
    public GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireShotgun());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator FireShotgun()
    {

        float rotationAngle = -225f;
        for (int i = 0; i < 10000; i++)
        {
            for (int j = 0; j < 1; j++)
            {
                switch (j)
                {
                    case 0:
                        CreatBullet(rotationAngle, firePoint.transform.position);
                        rotationAngle += -225f;
                        break;

                    


                }
            }

            yield return new WaitForSeconds(6f);


        }



    }

    private void CreatBullet(float rotationAngle, Vector3 firePosition)
    {
        Instantiate(bullet, firePosition, Quaternion.AngleAxis(rotationAngle, Vector3.forward));
    }



    
}


