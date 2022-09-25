using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
namespace godzillabanana
{

    public class Unicode : MonoBehaviour
    {
        public bool colided = false;
        public Camera mainCamera;
        //public Vector3 mousePos;
        public Drawing drawing;
        public Transform recentPos;
        public Transform ponyPos;
   public TMP_Text text;
        public float poopValue;
        public string unicornType;
        private float Timer = 5;
        public float TimerValue;
        public float poop;
        public Color color;
        public Color FriendColor;
        public float maxpoop;
        public Color babyColor;



        public GameObject unicornGene;
        public GameObject babyunicorn;
        // Start is called before the first frame update
        void Start()
        {

            text =  GetComponentInChildren(typeof(TMP_Text)) as TMP_Text;
            mainCamera = FindObjectOfType(typeof(Camera)) as Camera;
            color = gameObject.GetComponent<SpriteRenderer>().color;
            ponyPos = GetComponent<Transform>();

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            poop += poopValue;

            maxpoop = Mathf.Round(poop * 10.0f) * 0.1f;
            text.SetText(maxpoop.ToString());
          

        }

        public void bleed()
        {
            poop -= 5;
        }

        private void OnMouseDown()
        {
            Debug.Log("isClicked");
           // ponyPos.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            drawing.colorpick(this);


            //recentPos.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
        private void OnMouseDrag()
        {
            Debug.Log("isDragged");





           ponyPos.position = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500.0f));  


        }


        private void OnMouseUp()
        {
            if (colided)
            {
                Debug.Log("yay");
                
                GameObject babyunicorn = GameObject.Instantiate(unicornGene, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                babyunicorn.GetComponent<SpriteRenderer>().color = babyColor;

            }
        }


        private void OnTriggerEnter2D(Collider2D obj)
        {
            FriendColor = obj.GetComponent<SpriteRenderer>().color;
            babyColor = new Color(Mathf.Sqrt(color.r * FriendColor.r), Mathf.Sqrt(color.g * FriendColor.g), Mathf.Sqrt(color.b * FriendColor.b), 1.0f);


        }
        private void OnTriggerExit2D()
        {
            colided = false;
        }
    }
}
