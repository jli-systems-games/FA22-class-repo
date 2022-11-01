using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    // Start is called before the first frame update
    public int ID;

    public GameObject imageBox;
    private int material = 0;
    public GameObject sushi;
    public GameObject grillFish;

    public AudioSource sound;
    public Transform hand;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(material);
        if (material == 2)
        {
            
            cook();
            material = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            imageBox.SetActive(true);
        }
        if (ID == 1)
        {
            if (other.CompareTag("Finish"))
            {
                material++;
                Destroy(other.gameObject);
            }
            if (other.CompareTag("Ice"))
            {
                material++;
                Destroy(other.gameObject);
            }
        }else if (ID == 2)
        {
            if (other.CompareTag("Finish"))
            {
                material++;
                Destroy(other.gameObject);
            }
            if (other.CompareTag("Fuel"))
            {
                material++;
                Destroy(other.gameObject);
            }
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        imageBox.SetActive(false);
    }

    void cook()
    {
        sound.Play();
        if (ID == 1)
        {
            Instantiate(sushi, hand.position, Quaternion.identity);
        }else if (ID == 2)
        {
            Instantiate(grillFish, hand.position, Quaternion.identity);
        }
        

    }
}
