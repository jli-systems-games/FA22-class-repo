using UnityEngine;

namespace NickelVampireSurvive
{
    public class Enemy : MonoBehaviour
    {
        private Rigidbody2D _rb;
        public Transform player;
        [SerializeField] private float speed = 3f;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 direction= Vector2.MoveTowards(transform.position, player.position, speed);
            direction -= (Vector2)transform.position;
            _rb.velocity = direction;

        }
    }
}
    


