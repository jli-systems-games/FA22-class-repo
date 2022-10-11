using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace HectorRodriguez
{

    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Rigidbody2D))]

    public class Monster : MonoBehaviour
    {
        public new Rigidbody2D rigidbody { get; private set; }
        public SpriteRenderer spriteRenderer { get; private set; }
        public Sprite[] sprites;
        public AudioSource audioPlayer;

        public float size = 1f;
        public float minSize = 0.35f;
        public float maxSize = 1.65f;
        public float movementSpeed = 50f;
        public float maxLifetime = 30f;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
            transform.eulerAngles = new Vector3(0f, 0f, Random.value * 360f);

            transform.localScale = Vector3.one * size;
            rigidbody.mass = size;

            Destroy(gameObject, maxLifetime);
        }

        public void SetTrajectory(Vector2 direction)
        {
            rigidbody.AddForce(direction * movementSpeed);
        }
    }
}