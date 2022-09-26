using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ekaterina {

    public class PetUIController : MonoBehaviour
{
    public Image foodImage, happinessImage, energyImage;
    public static PetUIController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetUIController in the Scene");
    }

    public void UpdateImages(int food, int happiness, int energy)
    {
        foodImage.fillAmount = (float) food / 100;
        happinessImage.fillAmount = (float) happiness / 100;
        energyImage.fillAmount = (float) energy / 100;
    }


}
}

