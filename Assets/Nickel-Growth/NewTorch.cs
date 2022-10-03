using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelGrowth
{

    public class NewTorch : MonoBehaviour
    {
        private float RefreshTime;
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
            
            Torch.torchTime += 20;
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(propRefresh());
    }

        IEnumerator propRefresh()
        {
            yield return new WaitForSeconds(30);
            this.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<BoxCollider>().enabled = true;
        }


    }

}

