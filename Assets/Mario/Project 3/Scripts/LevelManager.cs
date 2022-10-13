using System;
using System.Collections.Generic;
using UnityEngine;

namespace MarioLifelike
{

    public class LevelManager : MonoBehaviour
    {
        public static LevelManager instance;

        [SerializeField]
        private List<HiddenObjectData> hiddenObjectsList;

        private List<HiddenObjectData> activeHiddenObjectsList;

        public List<Sprite> sprites;

        [SerializeField]
        private int maxActiveHiddenObjectsCount = 5;

        private int totalHiddenObjectsFound = 0;

        private void Awake()
        {
            if (instance == null) instance = this;
            else if (instance != null) Destroy(gameObject);
        }

        private void Start()
        {
            activeHiddenObjectsList = new List<HiddenObjectData>();
            AssignHiddenObjects();
        }

        void AssignHiddenObjects()
        {
            totalHiddenObjectsFound = 0;
            activeHiddenObjectsList.Clear();
            for (int i = 0; i < hiddenObjectsList.Count; i++)
            {
                hiddenObjectsList[i].hiddenObject.GetComponent<Collider2D>().enabled = false;
            }

            int k = 0;
            while(k < maxActiveHiddenObjectsCount)
            {
                int randomVal = UnityEngine.Random.Range(0, hiddenObjectsList.Count);

                if (!hiddenObjectsList[randomVal].makeHidden)
                {
                    hiddenObjectsList[randomVal].hiddenObject.name = "" + k;
                    hiddenObjectsList[randomVal].makeHidden = true;
                    hiddenObjectsList[randomVal].hiddenObject.GetComponent<Collider2D>().enabled = true;
                    hiddenObjectsList[randomVal].hiddenObject.GetComponent<SpriteRenderer>().sprite = sprites[UnityEngine.Random.Range(0, sprites.Count)];

                    activeHiddenObjectsList.Add(hiddenObjectsList[randomVal]);
                    
                    k++;
                }

            }
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

                if (hit && hit.collider != null)
                {
                    Debug.Log("Object Name:" + hit.collider.gameObject.name);

                    hit.collider.gameObject.SetActive(false);
                    for (int i = 0; i < activeHiddenObjectsList.Count; i++)
                    {
                        if (activeHiddenObjectsList[i].hiddenObject.name == hit.collider.gameObject.name)
                        {
                            activeHiddenObjectsList.RemoveAt(i);
                            break;
                        }
                    }

                    totalHiddenObjectsFound++;

                    if (totalHiddenObjectsFound >= maxActiveHiddenObjectsCount)
                    {
                        Debug.Log("Level Complete");
                    }
                }
            }
        }

    }

    [System.Serializable]

    public class HiddenObjectData
    {
        public string name;
        public GameObject hiddenObject;
        public bool makeHidden = false;
    }
}