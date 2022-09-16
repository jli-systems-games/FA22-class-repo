using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCollect : MonoBehaviour
{

    private int star = 0;

    [SerializeField] private Text starText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            Destroy(collision.gameObject);
            star++;
            starText.text = "Stars: " + star;
        }
        
    }
    
}
