using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Bananagodzilla
{
    

public class BodyManager : MonoBehaviour
{
    public RogueLimb[] heads;

    public RogueLimb[] bodies;
    
    public RogueLimb[] legs;

    public RogueLimb[]rightHands;
    public RogueLimb[] leftHands;
    public int h;
    public  int b;
    public  int l;
    public  int rh;
    public  int lh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchRightArm(int num)
    {
        rightHands[rh].GameObject().SetActive(false);
        rh += num;
        if (rh < 0)
        {
            rh = (rightHands.Length-1);
        }

        if (rh > rightHands.Length-1)
        {
            rh = 0;
        }
        rightHands[rh].GameObject().SetActive(true);
       
        
        Debug.Log(rh);
    }
}
}
