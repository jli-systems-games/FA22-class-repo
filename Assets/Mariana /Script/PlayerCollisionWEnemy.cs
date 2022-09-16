using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mariana
{

    public class PlayerCollisionWEnemy : MonoBehaviour
    {

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.transform.tag == "Enemy")
            {
                SceneManager.LoadScene(2);
            }
        }
    }

}