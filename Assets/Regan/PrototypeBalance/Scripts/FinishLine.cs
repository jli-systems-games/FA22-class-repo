using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Regan.Balance
{
    public class FinishLine : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer != 26) return;

            SceneManager.LoadScene("Regan.Balance.Menu");

        }
    }
}

