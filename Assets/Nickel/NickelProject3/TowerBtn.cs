using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nickelLifelike
{
    public class TowerBtn : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField]
        private GameObject towerPrefab;

        public GameObject TowerPrefab
        {
            get
            {
                return towerPrefab;
            }
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

