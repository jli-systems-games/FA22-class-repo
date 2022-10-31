using UnityEngine;

namespace AishasCircus{

    public class PlayerJumpCircus : MonoBehaviour
    {
        public Rigidbody2D rb;
        public float jumpAmount = 35;
        public float gravityScale = 10;
        public float fallingGravityScale = 40;
        public SpriteRenderer spriteRenderer;
        public Sprite newSprite;

        void Start(){
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }
        void ChangeSprite(Sprite newSprite)
        {
            spriteRenderer.sprite = newSprite; 
        }       
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
                ChangeSprite(newSprite); 
            }
            if(rb.velocity.y >= 0)
            {
                rb.gravityScale = gravityScale;
            }
            else if (rb.velocity.y < 0)
            {
                rb.gravityScale = fallingGravityScale;
            }
        }
    }
}