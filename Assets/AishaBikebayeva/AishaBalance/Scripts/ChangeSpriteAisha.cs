// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// namespace AishasCircus{
//     public class ChangeSpriteAisha : MonoBehaviour
//     {
//         public SpriteRenderer spriteRenderer;
//         public Sprite newSprite;
//         void ChangeSprite()
//         {
//         spriteRenderer.sprite = newSprite; 
//         }       
//         // Start is called before the first frame update
//         void Start()
//         {
//             spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
//         }

//         // Update is called once per frame
//         void Update()
//         {
            
//             if(Input.GetMouseButtonDown(0))
//             {
//                 ChangeSprite(newSprite);
//             }
//         }
//     }
// }