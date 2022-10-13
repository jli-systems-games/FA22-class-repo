using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour
{


   

   //private int level = 0;
   public void PlayGame()
   {
      SceneManager.LoadScene("SamPinballWorkshop");
   }

   public void Exit()
   {
      SceneManager.LoadScene("StartGame");
   }

   public void Controls()
   {
      SceneManager.LoadScene("Controls Page");
   }
   
   
   
}
