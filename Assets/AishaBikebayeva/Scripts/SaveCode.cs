using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AishaGrowth
{
    public class SaveCode : MonoBehaviour
    {

        public TMP_InputField nameField;

        public Slider healthSlider;
        
        public void saveData()
        {
            DataFile data = new DataFile(nameField.text,(int)healthSlider.value);
            string json = JsonUtility.ToJson(data);
            System.IO.File.WriteAllText(Application.persistentDataPath + "save.json", json);
            Debug.Log(Application.persistentDataPath);
        }
        
        public void loadData() 
        {
            string json = System.IO.File.ReadAllText(Application.persistentDataPath+"/save.json");
            DataFile data = JsonUtility.FromJson<DataFile>(json);
            nameField.text = data.name;
            healthSlider.value = data.health;
        }
    }
}