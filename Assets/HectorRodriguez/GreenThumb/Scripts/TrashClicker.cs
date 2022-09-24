using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TrashClicker : MonoBehaviour
{


    public int trash;
    public TMP_Text text;
    public int ValueIncreaseMultiplier = 1;

    private bool Upgrade1, Upgrade2;
    public Button Button1, Button2;

    void Start()
    {
        Upgrade1 = false;
        Upgrade2 = false;
    }

    //Can access outside of the script
    public void IncreaseValue()
    {

        trash = (trash + ValueIncreaseMultiplier);
    }

    public void IncreaseMulitplier(int value)
    {
        if (value == 1)
        {
            if (Upgrade1 == false)
            {
                if (value > 4)
                {
                    ValueIncreaseMultiplier = ValueIncreaseMultiplier + 1;
                    trash = trash - 5;
                    Upgrade1 = true;
                }
            }
        }
        if (value == 2)
        {
            if (Upgrade2 == false)
            {
                if (trash > 49)
                {
                    ValueIncreaseMultiplier = ValueIncreaseMultiplier + 2;
                    trash = trash - 50;
                    Upgrade2 = true;
                }
            }

        }
    }

    void Update()
    {
        text.text = trash.ToString();

        if (Upgrade1 == false)
        {

        }
        else
        {

        }
        if (Upgrade2 == false)
        {

        }
        else
        {

        }
    }
}