using UnityEngine;

namespace MunroVampireSurviours
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rb;

        [SerializeField] private float speed = 10f;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            _rb.velocity = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"))*speed;
        }
    }
}