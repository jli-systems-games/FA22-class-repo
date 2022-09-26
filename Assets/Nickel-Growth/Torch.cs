using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public static float torchTime = 10;
    private float torchTimeLocal;
    public Light torchLight;
    private float speed;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(torchTime);
        //StartCoroutine(LoadSubtitles());
        
        if (torchTime > 0)
        {

            torchTime -= Time.deltaTime;
            
            
        }
        if (torchTime > 3)
        {
            torchLight.intensity = 1.5f;
        }
        else if(torchTime < 3)
        {
            torchLight.intensity -= Time.deltaTime*0.5f;
        }
        else if (torchTime < 0)
        {
            //Debug.Log("Game Over");
        }
        
    }



    //IEnumerator LoadSubtitles()
    //{
    //    yield return new WaitForSeconds(torchTime);
        
    //    Debug.Log("you die");
    //}
}
