using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

            if (hit && hit.collider != null)
            {
                Debug.Log("Object Name:" + hit.collider.gameObject.name);
            }
        }
    }
}