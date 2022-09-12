using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{

    public float speed;
   

    // Start is called before the first frame update
    void Start()
    {   

       // public GameObject snake;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.Self); 
    }


//private void OnTriggerEnter(Collider col)
//{
 //   if (col.name == "Head")
 //   {
  //      snake.GetComponent<SnakeController>().getApple();
//    }
 //   else if(col.name =="Body Clone")
//    {

//    }
//}



}
