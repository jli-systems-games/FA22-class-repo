using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace WeiGame
{
    public class WeiCameraFollow : MonoBehaviour
    {


        public Transform player;
        public float smooth = 0.3f;
        Vector3 distance;

        // Start is called before the first frame update
        void Start()
        {
            distance = transform.position - player.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (player != null)
            {
                transform.position = Vector3.Lerp(transform.position, player.position + distance, smooth);
            }
        }
    }
}
