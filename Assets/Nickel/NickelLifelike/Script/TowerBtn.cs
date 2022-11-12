using UnityEngine;

namespace Nickel.NickelLifelike.Script
{
    public class TowerBtn : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField]
        private GameObject towerPrefab;
        [SerializeField]
        private int _maxAmount;
        public GameObject TowerPrefab
        {
            get
            {
                return towerPrefab;
            }
        }

        public int maxAmount
        {
            get
            {
                return _maxAmount;
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

