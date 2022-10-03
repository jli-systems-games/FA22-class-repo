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
        public float bloodValue = 0.05f;
        public float blood;
        public Color color;
        public Color FriendColor;
        public float maxBlood;
        public Color babyColor;
        public GameObject herd;
        public float u = 0.06f;
        public SpriteMango spriteRepo;
        public GameObject unicornGene;
        public GameObject babyunicorn;
        public TextMango txtMan;
        public bool delay = false;
        public float countdown = 20f;


        // Start is called before the first frame update
        void Start()
        {
            
            
            text =  GetComponentInChildren(typeof(TMP_Text)) as TMP_Text;
            mainCamera = FindObjectOfType(typeof(Camera)) as Camera;
            color = gameObject.GetComponent<SpriteRenderer>().color;
            ponyPos = GetComponent<Transform>();
            herd = GameObject.Find("Unicorns");
            drawing = FindObjectOfType(typeof(Drawing)) as Drawing;
            txtMan = FindObjectOfType(typeof(TextMango)) as TextMango;

        }


       
        // Update is called once per frame
        void Update()
        {
            color = gameObject.GetComponent<SpriteRenderer>().color;
            Vector3 mousePos = Input.mousePosition;
            blood += bloodValue;
            
            maxBlood = Mathf.Round(blood * 10.0f) * 0.1f;
            text.SetText(maxBlood.ToString()+" blood");

         



            if (blood <= 0)
            {
                StartCoroutine(selfDestruct());
            }
            



            if (!text)
            {
                text = GetComponentInChildren(typeof(TMP_Text)) as TMP_Text;
                mainCamera = FindObjectOfType(typeof(Camera)) as Camera;
                color = gameObject.GetComponent<SpriteRenderer>().color;
                ponyPos = GetComponent<Transform>();
                drawing = FindObjectOfType(typeof(Drawing)) as Drawing;
                herd = GameObject.Find("Unicorns");
                text.fontSize = 30;
            }
           
            
            if (!unicornGene)
            {
                unicornGene = GameObject.Find("UnicornB");
            }
            
            if (!spriteRepo)
            {
                spriteRepo = FindObjectOfType(typeof(SpriteMango)) as SpriteMango;

                spriteRepo.spritePick();
                GetComponent<SpriteRenderer>().sprite = spriteRepo.currentSprite;
            }

        }

        public void bleed()
        {
            blood -= 5;
            txtMan.bleedMessage();
        }

        private void OnMouseDown()
        {
            //Debug.Log("isClicked");
           // ponyPos.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            drawing.colorpick(this);


            //recentPos.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
        private void OnMouseDrag()
        {
            //Debug.Log("isDragged");





           ponyPos.position = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500.0f));  


        }


        private void OnMouseUp()
        {
            if (collided)
            {
               
                
                GameObject babyunicorn = Instantiate(unicornGene, new Vector3 (-380, -480, 0), Quaternion.identity) as GameObject;
                babyunicorn.GetComponent<SpriteRenderer>().color = babyColor;
                babyunicorn.transform.SetParent(herd.transform, false);
                txtMan.cloneMessage();


            }
        }


        private void OnTriggerEnter2D(Collider2D obj)
        {
            collided = true;

            FriendColor = obj.GetComponent<SpriteRenderer>().color;
            //babyColor = new Color(Mathf.Sqrt(color.r * FriendColor.r), Mathf.Sqrt(color.g * FriendColor.g), Mathf.Sqrt(color.b * FriendColor.b), 1.0f);
            babyColor = new Color((color.r + FriendColor.r)/2+Random.Range(-u, u), (color.g + FriendColor.g)/2 + Random.Range(-u, u), (color.b + FriendColor.b)/2 + Random.Range(-u, u), 1.0f);

        }
        private void OnTriggerExit2D()
        {
            collided = false;
        }



        IEnumerator selfDestruct()
        {
            txtMan.killMessage();
            Debug.Log("bebe");
            yield return new WaitForEndOfFrame();
           // Debug.Log("pikpik");
            Destroy(gameObject);
            

        }
    }
}
