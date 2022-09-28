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
        public bool collided = false;
        public Camera mainCamera;
        //public Vector3 mousePos;
        public Drawing drawing;
        public Transform recentPos;
        public Transform ponyPos;
   public TMP_Text text;
        public float bloodValue = 0.1f;
        public float blood;
        public Color color;
        public Color FriendColor;
        public float maxBlood;
        public Color babyColor;
        public GameObject herd;


        public GameObject unicornGene;
        public GameObject babyunicorn;
        // Start is called before the first frame update
        void Start()
        {
            
            
            text =  GetComponentInChildren(typeof(TMP_Text)) as TMP_Text;
            mainCamera = FindObjectOfType(typeof(Camera)) as Camera;
            color = gameObject.GetComponent<SpriteRenderer>().color;
            ponyPos = GetComponent<Transform>();
            herd = GameObject.Find("Unicorns");
            drawing = FindObjectOfType(typeof(Drawing)) as Drawing;


        }


       
        // Update is called once per frame
        void Update()
        {
            color = gameObject.GetComponent<SpriteRenderer>().color;
            Vector3 mousePos = Input.mousePosition;
            blood += bloodValue;

            maxBlood = Mathf.Round(blood * 10.0f) * 0.1f;
            text.SetText(maxBlood.ToString());

            if (blood <= -1)
            {
                Destroy(gameObject);
            }






            if (text == null)
            {
                text = GetComponentInChildren(typeof(TMP_Text)) as TMP_Text;
                
            }
            if (mainCamera == null)
            {
                mainCamera = FindObjectOfType(typeof(Camera)) as Camera;
                
            }

            if (color == null)
            {
                color = gameObject.GetComponent<SpriteRenderer>().color;
            }
            if (ponyPos== null)
            {
                ponyPos = GetComponent<Transform>();
            }
           if (drawing == null)
            {
                drawing = FindObjectOfType(typeof(Drawing)) as Drawing;
            }
            if (herd == null) { herd = GameObject.Find("Unicorns"); }
            if (!unicornGene)
            {
                unicornGene = GameObject.Find("UnicornB");
            }
            


        }

        public void bleed()
        {
            blood -= 5;
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
            if (collided)
            {
               
                
                GameObject babyunicorn = Instantiate(unicornGene, new Vector3 (-500, -400, 0), Quaternion.identity) as GameObject;
                babyunicorn.GetComponent<SpriteRenderer>().color = babyColor;
                babyunicorn.transform.SetParent(herd.transform, false);
                

            }
        }


        private void OnTriggerEnter2D(Collider2D obj)
        {
            collided = true;

            FriendColor = obj.GetComponent<SpriteRenderer>().color;
            //babyColor = new Color(Mathf.Sqrt(color.r * FriendColor.r), Mathf.Sqrt(color.g * FriendColor.g), Mathf.Sqrt(color.b * FriendColor.b), 1.0f);
            babyColor = new Color((color.r + FriendColor.r)/2, (color.g + FriendColor.g)/2, (color.b + FriendColor.b)/2, 1.0f);

        }
        private void OnTriggerExit2D()
        {
            collided = false;
        }
    }
}
