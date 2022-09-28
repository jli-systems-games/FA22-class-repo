using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Max 
{ 

public class key : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {
        isFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    //IF YOURE READING THIS, im struggling and just commented this part out for the time being so the script works.
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.tag == "Player")
    //    {
    //        if (!isFollowing)
    //        {
    //            PlayerController thePlayer = FindObjectOfType<PlayerController>();
    //
    //           followTarget = thePlayer.transform;
    //        }
    //    }
    }
}
