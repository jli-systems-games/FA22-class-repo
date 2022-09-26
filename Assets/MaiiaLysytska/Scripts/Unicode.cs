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
        public float poopValue;
        public string unicornType;
        private float Timer = 5;
        public float TimerValue;
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

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            blood += poopValue;

            maxBlood = Mathf.Round(blood * 10.0f) * 0.1f;
            text.SetText(maxBlood.ToString());

            if (blood <= 0)
            {
                Destroy(this);
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
               
                
                GameObject babyunicorn = Instantiate(unicornGene, new Vector3 (100, 100, 0), Quaternion.identity) as GameObject;
                babyunicorn.GetComponent<SpriteRenderer>().color = babyColor;
                babyunicorn.transform.SetParent(herd.transform, false);

            }
        }


        private void OnTriggerEnter2D(Collider2D obj)
        {
            collided = true;

            FriendColor = obj.GetComponent<SpriteRenderer>().color;
            babyColor = new Color(Mathf.Sqrt(color.r * FriendColor.r), Mathf.Sqrt(color.g * FriendColor.g), Mathf.Sqrt(color.b * FriendColor.b), 1.0f);


        }
        private void OnTriggerExit2D()
        {
            collided = false;
        }
    }
}
