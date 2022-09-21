using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hector
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class AnimatedSprite : MonoBehaviour
    {

        public SpriteRenderer spriteRenderer { get; private set; }

        public Sprite[] sprites;

        public float animationTime = 0.25f;
        public int animationFrame { get; private set; }

        public bool loop = true;

        private void Awake()
        {
            this.spriteRenderer = GetComponent<SpriteRenderer>();

        }


        private void Start()
        {
            InvokeRepeating(nameof(Advance), animationTime, animationTime);
        }


        private void Advance()
        {
            if (!spriteRenderer.enabled)
            {
                return;

            }
            animationFrame++;

            if (animationFrame >= sprites.Length && loop)
            {
                animationFrame = 0;
            }

            if (animationFrame >= 0 && animationFrame < sprites.Length)
            {
                spriteRenderer.sprite = sprites[animationFrame];


            }
        }

        public void Restart()
        {
            animationFrame = -1;

            Advance();
        }
    }
}