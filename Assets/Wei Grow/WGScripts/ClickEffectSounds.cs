using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Bloom
{

    public class ClickEffectSounds : MonoBehaviour


    {

        private Vector3 point;
        public GameObject[] effects;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f);
                point = Camera.main.ScreenToWorldPoint(point);
                int effectsIndex = Random.Range(0, effects.Length);
                GameObject click = Instantiate(effects[effectsIndex]);
                click.transform.position = point;
                Destroy(click, 0.5f);
            }



        }


    }
}
