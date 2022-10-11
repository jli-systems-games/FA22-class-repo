using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public Camera mainCamera;
    public Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void BackgroundChange()
    {
        mainCamera.backgroundColor = newColor;
    }
}
