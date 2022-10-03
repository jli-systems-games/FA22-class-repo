using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hint : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text hintBox;
    public string hint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(PlayerHint());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator PlayerHint()
    {
        hintBox.text = hint;
        yield return new WaitForSeconds(3);
        hintBox.text = " ";



    }
}
