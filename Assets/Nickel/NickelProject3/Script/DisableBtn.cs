using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class DisableBtn : MonoBehaviour
    {
        public int maxCount;
        public string tagOfPrefab;
        private int numberOfTaggedObjects;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            numberOfTaggedObjects = GameObject.FindGameObjectsWithTag(tagOfPrefab).Length;
            //Debug.Log(numberOfTaggedObjects);
            if (numberOfTaggedObjects == maxCount)
            {
                Destroy(gameObject);
            }
        }
    }

}
