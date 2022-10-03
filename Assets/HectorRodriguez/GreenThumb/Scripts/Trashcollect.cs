using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Trashcollect : MonoBehaviour
{
    public GameObject trashPrefab;
    public bool harmful;

    public float startForce = 15f;

    [SerializeField] private AudioClip DeathSoundEffect;

    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);

    }




    private void OnTriggerEnter2D(Collider2D col)

    {
        if (col.gameObject.CompareTag("Plastic"))
        {

            Vector2 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject Plasticbottle = Instantiate(trashPrefab, transform.position, rotation);
            if (!harmful)
            {

                RecycleClicker.instance.IncreasePlastic();

            }
            else
            {
                RecycleClicker.instance.Substractplastic();

            }
            if (DeathSoundEffect != null)
            {
                AudioSource.PlayClipAtPoint(DeathSoundEffect, transform.position, 1.5f);
            }
            Destroy(Plasticbottle, 10f);
            Destroy(gameObject);
        }

        else if (col.gameObject.CompareTag("Metal"))
        {
            Vector2 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject Metal = Instantiate(trashPrefab, transform.position, rotation);
            Destroy(Metal, 10f);
            Destroy(gameObject);


            if (!harmful)
            {

                RecycleClicker.instance.IncreaseMetal();

            }
            else
            {
                RecycleClicker.instance.Substractplastic();

            }
        }
    }
}



        