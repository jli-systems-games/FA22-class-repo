using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    

public class FlipObject : MonoBehaviour
{
    public GameObject[] item;
    public int num;

   public void changeStick() {
       item[num].SetActive(false);
       num++;
       if (num > item.Length - 1)
       {
           num = 0;
       } 
       item[num].SetActive(true);


   }



}
}
