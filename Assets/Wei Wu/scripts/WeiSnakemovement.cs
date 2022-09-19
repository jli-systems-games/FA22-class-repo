using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeiSnakemovement : MonoBehaviour
{

    public float MoveSpeed = 5;
    public float SteerSpeed = 180;
    public float BodySpeed = 5;
    public int Gap = 10;
    public GameObject collectedEffect;
    public GameObject collectedEffect2;

    public GameObject BodyPrefab;
    private List<GameObject> BodyParts = new List<GameObject>();
    private List<Vector3> PositionsHistory = new List<Vector3>();
    private MeshRenderer _meshRenderer;
    private Collider _Collider;

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = transform.GetComponent<MeshRenderer>();
        _Collider = transform.GetComponent<Collider>();

       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * MoveSpeed * Time.deltaTime;

        



        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * steerDirection * SteerSpeed * Time.deltaTime);


        PositionsHistory.Insert(0, transform.position);

        int index = 0;
        foreach (var body in BodyParts)
        {
            Vector3 point = PositionsHistory[Mathf.Min(index * Gap, PositionsHistory.Count - 1)];
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * BodySpeed * Time.deltaTime;
            body.transform.LookAt(point);
            index++;
        }


    }


    private void GrowSnake ()
    {
        GameObject body = Instantiate(BodyPrefab);
        BodyParts.Add(body);


    }

    

    


    private void ReduceSnake()
    {
        GameObject tail = BodyParts[0];
        BodyParts.RemoveAt(index: 0);

        Destroy(tail);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GrowSnake();

            Instantiate(collectedEffect2);


            //collectedEffect.SetActive(true);


        }

        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(02);

            //collectedEffect.SetActive(true);


        }

        if (other.gameObject.tag == "Respawn")
        {
            ReduceSnake();


            Instantiate(collectedEffect);


        }

    }

    }
