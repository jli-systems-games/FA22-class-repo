using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Bananagodzilla
{

    public class RogueBGmanager : MonoBehaviour
    {


        public Sprite[] Backgrounds;

        public Image dungeon;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SwitchImage()
        {
            dungeon.sprite = Backgrounds[Random.Range(0, 8)];
            Debug.Log("chosen bg");
        }
    }

}