using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute : MonoBehaviour
{
    public Light torchLight;
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
        torchLight.range = 45;
        StartCoroutine(TorchWider());
    }

    IEnumerator TorchWider()
    {
        yield return new WaitForSeconds(10);
        torchLight.range = 20;
    }
}
