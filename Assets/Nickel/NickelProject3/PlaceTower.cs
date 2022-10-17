using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace nickelLifelike
{
    public class PlaceTower : MonoBehaviour
    {
        public GameObject towerPrefab;
        private int test;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(test);
        }

        private void OnMouseOver()
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                PlaceATower();
                test++;
            }
        }

        private void PlaceATower()
        {
            if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0f;
                //Debug.Log("placing a tower");
                Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab, mousePos, Quaternion.identity);
            }
            

            
        }
    }

}

