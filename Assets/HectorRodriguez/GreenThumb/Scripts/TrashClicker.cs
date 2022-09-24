using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TrashClicker : MonoBehaviour
{


    public int trash;
    public TMP_Text text;

    //Can access outside of the script
    public void IncreaseValue()
    {
        trash = (trash + 1);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = trash.ToString();
    }
}
