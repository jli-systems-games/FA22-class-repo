using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HectorRodriguez { 

public class Respawn : MonoBehaviour
{
    public float threshold;

        void FixedUpdate()
        {
            if (transform.position.y < threshold)
                transform.position = new Vector3(0, 0, 0);

            else if (transform.position.y < threshold)

                SceneManager.LoadScene("EndGame");
        }
    }
}


