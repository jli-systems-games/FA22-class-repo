using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{

    public GameObject bodyprefab;
    public GameObject head;
    private int length;
    private Vector3 up = new Vector3(0, 1, 0);
    private Vector3 down = new Vector3(0, -1, 0);
    private Vector3 left = new Vector3(-1, 0, 0);
    private Vector3 right = new Vector3(1, 0, 0);
    private Vector3 direction;
    private float timer;
    public float threshold;
    private BoxCollider2D _boxCollider2D;



    // Start is called before the first frame update
    void Start()
    {
        length = 3;
        direction = up;
        for(int n = 0; n < length; n++)

        {
            GameObject body = Instantiate(bodyprefab, transform);
            body.transform.position = new Vector3(head.transform.position.x, head.transform.position.y-(n+1), head.transform.position.y);
        }



    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            direction = up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = right;
        }

        if (timer>threshold) {
            for(int n = length-1;n>0;n--)
            {
                transform.GetChild(n).transform.position = transform.GetChild(n - 1).transform.position;

            }

            transform.GetChild(0).transform.position = head.transform.position;
            head.transform.position += direction;
            timer = 0;

        }
        timer += Time.deltaTime;



    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.tag == "Enemy")
        {
            GameObject body = Instantiate(bodyprefab, transform);
            body.transform.position = transform.GetChild(length - 1).position;
            length++;
            if (threshold > 0.1f)
            {
                threshold -= 0.05f;
            }
        }
    }





}
