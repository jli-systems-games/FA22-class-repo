using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HectorRodriguez {
public class Thumb : MonoBehaviour
{
    public GameObject thumbTrailPrefab;
    public float minCuttingVelocity = .001f;

    bool isCutting = false;


    Vector2 previousPosition;


    GameObject currentThumbTrail;

    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;



    void Start()
    {
        cam = Camera.main;

        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCutting();

        }
        else if (Input.GetMouseButton(0))
        {
            StopCutting();
        }


        if (isCutting)
        {
            UpdateCut();
        }
    }


    void UpdateCut()
    {

        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;


        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;

        if (velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }

        previousPosition = newPosition;
    }



    void StartCutting()
    {
        isCutting = true;
        currentThumbTrail = Instantiate(thumbTrailPrefab, transform);
        previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        circleCollider.enabled = false;


    }

    void StopCutting()
    {

        isCutting = false;
        currentThumbTrail.transform.SetParent(null);
        Destroy(currentThumbTrail, 2f);
        circleCollider.enabled = false;

    }

}

}