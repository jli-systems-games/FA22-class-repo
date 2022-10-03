using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Bloom
{
    public class ClickEffect : MonoBehaviour
    {
        private Vector3 point;
        public GameObject effectGo;

        void Start()
        {

        }


        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f);
                point = Camera.main.ScreenToWorldPoint(point);
                GameObject go = Instantiate(effectGo);
                go.transform.position = point;
                Destroy(go, 0.5f);
            }
        }
    }
}