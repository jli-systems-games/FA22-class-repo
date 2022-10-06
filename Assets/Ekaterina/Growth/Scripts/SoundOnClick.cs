using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Ekaterina{
    public class SoundOnClick : MonoBehaviour
{
    public AudioSource sound;
    public Button Button;
    void Start () {
            Button btn = Button.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
            }
    
            void TaskOnClick(){
                sound.Play();
            }
}
}
