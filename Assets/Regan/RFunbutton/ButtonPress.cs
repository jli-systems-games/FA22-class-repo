using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReganFunButton
{

    public class ButtonPress : MonoBehaviour
    {
        public GameObject Runt;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);
                Vector3 spawn = new Vector3(Random.Range(-1f, 2f), Random.Range(-1f, 1f), 0f);

                if (hit && hit.collider != null)
                {
                    Debug.Log("Object Name:" + hit.collider.gameObject.name);
                    Instantiate(Runt, spawn, Quaternion.identity);
                }
            }
        }
    }
}