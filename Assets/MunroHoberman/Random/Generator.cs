using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject dotObject;

    public int width=6;
    public int height=6;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int x=0; x<width; x++) {
            for (int y=0; y<height;y++) {
                GameObject dot=Instantiate(dotObject,new Vector3 (x-width/2+.5f,y-height/2+.5f,0),Quaternion.identity);
                float size = Random.Range(.25f, 1f);
                dot.transform.localScale = new Vector3(size,size,1);
            }
        }
    }
}
