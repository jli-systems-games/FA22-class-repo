
using Unity.VisualScripting;
using UnityEngine;

namespace Bananagodzilla{
    

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

    public RogueHero hero;

    void Start()
    {
        hero = FindObjectOfType(typeof (RogueHero)) as RogueHero;
    }

    public void getBody()
    {
        hero.limbCheck(leftHands[0]);
        hero.limbCheck(rightHands[0]);
        hero.limbCheck(heads[0]);
        hero.limbCheck(bodies[0]);
        hero.limbCheck(legs[0]);
    }
    
    
    public void SwitchLeftArm()
    {
        hero.limbRemove(leftHands[lh]);
        leftHands[lh].GameObject().SetActive(false);
        lh ++;
        if (lh < 0)
        {
            lh = (leftHands.Length-1);
        }

        if (lh > leftHands.Length-1)
        {
            lh = 0;
        }
        leftHands[lh].GameObject().SetActive(true);
        hero.limbCheck(leftHands[lh]);


        // Debug.Log(lh);
    }

    public void SwitchHead()
    {
        hero.limbRemove(heads[h]);
        heads[h].GameObject().SetActive(false);
        h ++;
        if (h < 0)
        {
            h = (heads.Length-1);
        }

        if (h > heads.Length-1)
        {
            h = 0;
        }
        heads[h].GameObject().SetActive(true);
        hero.limbCheck(heads[h]);

        //Debug.Log(h);
    }
    
    public void SwitchLegs()
    {
        hero.limbRemove(legs[l]);
        legs[l].GameObject().SetActive(false);
        l ++;
        if (l < 0)
        {
            l = (legs.Length-1);
        }

        if (l > legs.Length-1)
        {
            l = 0;
        }
        legs[l].GameObject().SetActive(true);

        hero.limbCheck(legs[l]);
        //Debug.Log(l);
    }

    public void SwitchRightArm()
    {
        hero.limbRemove(rightHands[rh]);
        rightHands[rh].GameObject().SetActive(false);
        rh ++;
        if (rh < 0)
        {
            rh = (rightHands.Length-1);
        }

        if (rh > rightHands.Length-1)
        {
            rh = 0;
        }
        rightHands[rh].GameObject().SetActive(true);
        hero.limbCheck(rightHands[rh]);

        // Debug.Log(rh);
    }
    
    public void SwitchBody()
    {
        hero.limbRemove(bodies[b]);
        bodies[b].GameObject().SetActive(false);
        b ++;
        if (b < 0)
        {
            b = (bodies.Length-1);
        }

        if (b > bodies.Length-1)
        {
            b = 0;
        }
        bodies[b].GameObject().SetActive(true);

        hero.limbCheck(bodies[b]);
        //Debug.Log(b);
    }
    
    
    
    
    
}
}
