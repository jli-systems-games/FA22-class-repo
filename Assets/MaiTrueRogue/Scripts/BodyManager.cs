
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


    public int bodyCount;
    public RogueHero hero;

    void Start()
    {
        hero = FindObjectOfType(typeof (RogueHero)) as RogueHero;
    }

    public void getBody()
    {
        hero.limbCheck(leftHands[lh]);
        hero.limbCheck(rightHands[rh]);
        hero.limbCheck(heads[h]);
        hero.limbCheck(bodies[b]);
        hero.limbCheck(legs[l]);
    }
    
    
    public void SwitchLeftArm()
    {
        hero.limbRemove(leftHands[lh]);
        leftHands[lh].gameObject.SetActive(false);
        lh ++;
        if (lh < 0)
        {
            lh = (bodyCount-1);
        }

        if (lh > bodyCount-1)
        {
            lh = 0;
        }
        leftHands[lh].gameObject.SetActive(true);
        hero.limbCheck(leftHands[lh]);


        // Debug.Log(lh);
    }

    public void SwitchHead()
    {
        hero.limbRemove(heads[h]);
        heads[h].gameObject.SetActive(false);
        h ++;
        if (h < 0)
        {
            h = (bodyCount-1);
        }

        if (h > bodyCount-1)
        {
            h = 0;
        }
        heads[h].gameObject.SetActive(true);
        hero.limbCheck(heads[h]);

        //Debug.Log(h);
    }
    
    public void SwitchLegs()
    {
        hero.limbRemove(legs[l]);
        legs[l].gameObject.SetActive(false);
        l ++;
        if (l < 0)
        {
            l = (bodyCount-1);
        }

        if (l > bodyCount-1)
        {
            l = 0;
        }
        legs[l].gameObject.SetActive(true);

        hero.limbCheck(legs[l]);
        //Debug.Log(l);
    }

    public void SwitchRightArm()
    {
        hero.limbRemove(rightHands[rh]);
        rightHands[rh].gameObject.SetActive(false);
        rh ++;
        if (rh < 0)
        {
            rh = (bodyCount-1);
        }

        if (rh > bodyCount-1)
        {
            rh = 0;
        }
        rightHands[rh].gameObject.SetActive(true);
        hero.limbCheck(rightHands[rh]);

        // Debug.Log(rh);
    }
    
    public void SwitchBody()
    {
        hero.limbRemove(bodies[b]);
        bodies[b].gameObject.SetActive(false);
        b ++;
        if (b < 0)
        {
            b = (bodyCount-1);
        }

        if (b > bodyCount-1)
        {
            b = 0;
        }
        bodies[b].gameObject.SetActive(true);

        hero.limbCheck(bodies[b]);
        //Debug.Log(b);
    }

    public void Explode()
    {
       heads[h].GetComponent<Rigidbody2D>().velocity =
           new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
       bodies[b].GetComponent<Rigidbody2D>().velocity =
           new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
       rightHands[rh].GetComponent<Rigidbody2D>().velocity =
           new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
      leftHands[lh].GetComponent<Rigidbody2D>().velocity =
           new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
      legs[l].GetComponent<Rigidbody2D>().velocity =
          new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
    }
    
    
    
    
}
}
