using UnityEngine;

namespace MarianaVampireSurvivors
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rb;

        [SerializeField] private float speed = 18f;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();

        }

        // Update is called once per frame
        void Update()
        {
            _rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;

        }
    }

}

