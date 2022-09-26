using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public static float torchTime = 5;
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
        //Debug.Log(torchTime);
        //StartCoroutine(LoadSubtitles());
        torchLight.intensity = torchTime;
        if (torchTime > 0)
        {
            torchTime -= Time.deltaTime;
            
            
        }
        if (torchTime < 0)
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
