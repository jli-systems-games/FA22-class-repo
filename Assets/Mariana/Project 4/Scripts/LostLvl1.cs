using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana
{
public class LostLvl1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
              {
                  if (other.gameObject.tag == "Player")
                      SceneManager.LoadScene("Water");
              }
}
}